using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using Tesis.Models.Dominio.Movimientos;

namespace Tests
{
    public class TiposDeMovimientoTests : BaseTest
    {

        [Test]
        public async Task MovimientosIsNotNull()
        {
            var result = await client.GetGraphQLAsync(@"{ ""query"" : ""query { TiposDeMovimiento { ID Nombre } }"" }");
            var tipos = JsonConvert.DeserializeObject<List<TiposDeMovimiento>>(result["data"]["TiposDeMovimiento"].ToString());
            Assert.AreEqual(tipos != null, true);
        }

        [Test]
        public async Task OnlyExistTwo()
        {
            var result = await client.GetGraphQLAsync(@"{ ""query"" : ""query { TiposDeMovimiento { ID Nombre } }"" }");
            var tipos = JsonConvert.DeserializeObject<List<TiposDeMovimiento>>(result["data"]["TiposDeMovimiento"].ToString());
            Assert.AreEqual(tipos.Count == 2, true);
        }

        [Test]
        public async Task DebeExists()
        {
            var result = await client.GetGraphQLAsync(@"{ ""query"" : ""query { TiposDeMovimiento { ID Nombre } }"" }");
            var tipos = JsonConvert.DeserializeObject<List<TiposDeMovimiento>>(result["data"]["TiposDeMovimiento"].ToString());
            Assert.AreEqual(tipos.Exists(x => x.Nombre.ToLower().Equals("debe")), true);
        }

        [Test]
        public async Task HaberExists()
        {
            var result = await client.GetGraphQLAsync(@"{ ""query"" : ""query { TiposDeMovimiento { ID Nombre } }"" }");
            var tipos = JsonConvert.DeserializeObject<List<TiposDeMovimiento>>(result["data"]["TiposDeMovimiento"].ToString());
            Assert.AreEqual(tipos.Exists(x => x.Nombre.ToLower().Equals("haber")), true);
        }


    }
}