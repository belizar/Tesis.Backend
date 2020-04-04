using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;

namespace Tests
{
    public class ParametrosTest : BaseTest
    {
        [Test]
        public async Task CreateParameter()
        {
            var content = new StringContent(JsonConvert.SerializeObject( new Parametros() { TasaMora = 5, TEM = 2 }),
                                            Encoding.UTF8,
                                            "application/json");

            var response = await client.PostAsync("parametros/create", content);

            Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public async Task GetActive()
        {
            var result = await client.GetGraphQLAsync(@"{ ""query"" : ""query { ParametrosGetActive { ID TEM TasaMora } }"" }");
            var tipos = JsonConvert.DeserializeObject<Parametros>(result["data"]["ParametrosGetActive"].ToString());
            Assert.AreEqual(tipos != null, true);
        }


        [Test]
        public async Task GetAll_ShouldBeOne()
        {
            var result = await client.GetGraphQLAsync(@"{ ""query"" : ""query { Parametros { ID TEM TasaMora } }"" }");
            var tipos = JsonConvert.DeserializeObject<List<Parametros>>(result["data"]["Parametros"].ToString());
            Assert.AreEqual(tipos.Count == 1, true);
        }

    }
}
