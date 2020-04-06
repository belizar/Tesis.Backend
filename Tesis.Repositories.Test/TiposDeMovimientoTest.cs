﻿using Microsoft.EntityFrameworkCore;
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
    public class TiposDeMovimientoTest
    {
        private ITiposDeMovimientoRepository repo;

        [SetUp]
        public void Init()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AlimaDataContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Alima;User Id=SA;Password=3Lmund0!");
            repo = new TiposDeMovimientoRepository(new AlimaDataContext(optionsBuilder.Options));
        }

        [Test]
        public async Task ExistenTiposDeMovimiento()
        {
            var tipos = await repo.FindAll();

            Assert.AreEqual(tipos != null, true);
            Assert.AreEqual(tipos.Count() > 0, true);
        }
    }
}
