using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesis.Repositories.Definition.Repositories;
using Tesis.Repositories.Implementation.Repositories;
using Tesis.Repositories.Implementations;

namespace Tesis.Repositories.Test
{
    [TestFixture]
    public class PageClienteTest
    {
        private IClienteRepository repo;

        [SetUp]
        public void Init()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AlimaDataContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Alima;User Id=SA;Password=3Lmund0!");
            repo = new ClienteRepository(new AlimaDataContext(optionsBuilder.Options));
        }

        [Test]
        public async Task TraeUnaPaginaDeClientes()
        {
            var page = await repo.GetPage(5, 0);
            var secondPage = await repo.GetPage(5, 5);
            // Assert.AreEqual(tipos != null, true);
            // Assert.AreEqual(tipos.Count() > 0, true);
        }
    }
}
