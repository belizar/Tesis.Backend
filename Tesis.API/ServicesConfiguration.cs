using FluentValidation;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Linq;
using System.Reflection;
using Tesis.API.Firebase;
using Tesis.API.GraphQL;
using Tesis.Bussiness.Definition;
using Tesis.Bussiness.Implementation.Services;
using Tesis.Bussiness.Implementation.Validations;
using Tesis.Models.Dominio.Credito;
using Tesis.Repositories.Definition;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementation;
using Tesis.Repositories.Implementation.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.API
{
    public static class ServicesConfiguration
    {

        public static void AddGraphQLConfig(this IServiceCollection @this)
        {
            @this.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            @this.AddScoped<ISchema, TesisSchema>();
            @this.AddScoped<IDocumentExecuter, DocumentExecuter>();
            @this.AddScoped<TesisQuery>();
            AddGraphqlTypes(@this);
        }

        private static void AddGraphqlTypes(IServiceCollection @this)
        {
            var method = typeof(ServicesConfiguration).GetMethod("AddScopedHelper", BindingFlags.Public | BindingFlags.Static);
            Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(x => x.Name.EndsWith("Type"))
                    .ToList()
                    .ForEach(type =>
                    {
                        method.MakeGenericMethod(new Type[] { type }).Invoke(null, new object[] { @this } );
                    });
        }

        public static void AddScopedHelper<T>(IServiceCollection @this) where T : class
        {
            @this.AddScoped<T>();
        }

        public static void AddDbConfig(this IServiceCollection @this, IConfiguration Configuration)
        {
            @this.AddDbContext<AlimaDataContext>(options =>  options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        public static void AddRepositories(this IServiceCollection @this)
        {
            @this.AddScoped<IParametrosRepository, ParametrosRepository>();
            @this.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static void AddAuthentication(this IServiceCollection @this, IConfiguration Configuration)
        {
            @this.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                 .AddJwtBearer(options =>
                    {
                        options.Authority = "https://securetoken.google.com/tesis-213dc";
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                        ValidateIssuer = true,
                        ValidIssuer = "https://securetoken.google.com/tesis-213dc",
                        ValidateAudience = true,
                        ValidAudience = "tesis-213dc",
                        ValidateLifetime = true
                    };
                 });

        }

        public static void AddAuthorization(this IServiceCollection @this, IConfiguration Configuration)
        {
            //@this.AddAuthorization(options =>
            //{
            //    //options.AddPolicy("read:data", policy => policy.Requirements.Add(new HasScopeRequirement("read:data", Configuration["Auth0:Domain"])));
            //});

            //@this.AddSingleton<IAuthorizationHandler, HasScopeHandler>();
        }

        public static void AddBussinessServices(this IServiceCollection @this)
        {
            @this.AddScoped<IParametrosService, ParametrosService>();
            @this.AddScoped<IClienteService, ClienteService>();
            @this.AddScoped<ICreditoService, CreditoService>();
            @this.AddScoped<IMovimientosService, MovimientosService>();
        }

        public static void AddValidationServices(this IServiceCollection @this)
        {
            @this.AddScoped<IValidator<Parametros>, ParametroValidation>();
        }

        public static void AddValidationErrors(this IServiceCollection @this)
        {
            @this.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = (context) =>
                {
                    var errors = context.ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage)).ToList();

                    var result = new
                    {
                        Code = "00009",
                        Message = "Validation Errors",
                        Errors = errors
                    };

                    return new BadRequestObjectResult(result);
                };
            });
        }

        public static void AddFirebaseAdmin(this IServiceCollection @this)
        {
            @this.AddSingleton<IFirebaseService, FirebaseService>();
        }
    }
}
