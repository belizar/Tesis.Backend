using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Implementation
{
    public class DesignTimeFactory : IDesignTimeDbContextFactory<AlimaDataContext>
    {
        public AlimaDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AlimaDataContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Alima;User Id=SA;Password=3Lmund0!");

            return new AlimaDataContext(optionsBuilder.Options);
        }
    }
}
