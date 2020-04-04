using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;

namespace Tests
{
    public class CreditosTest : BaseTest
    {
        [Test]
        public async Task CreateCredito()
        {
            var credito = new Credito();

            credito.Cuotas = new List<Cuota>();
            credito.Cuotas.Add(new Cuota()
            {
                Numero = 1,
                Monto = 2300,
                Vencimiento = new DateTime(2019, 07, 5)
            });
            credito.Cuotas.Add(new Cuota()
            {
                Numero = 2,
                Monto = 2300,
                Vencimiento = new DateTime(2019, 08, 5)
            });
            credito.Cuotas.Add(new Cuota()
            {
                Numero = 3,
                Monto = 2300,
                Vencimiento = new DateTime(2019, 09, 5)
            });

            credito.PropietarioID = 1;
            credito.GaranteID = 2;
            credito.GastosAdministrativos = 200;
            credito.ParametroID = 1;
            credito.MontoSolicitado = 6000;
            credito.EstadoDeCreditoID = (int) EstadoDeCredito.eId.PendienteDeAprobar;
            var response = await client.PostAsync("creditos/create", new StringContent(JsonConvert.SerializeObject(credito), Encoding.UTF8, "application/json"));

            Assert.AreEqual( HttpStatusCode.OK, response.StatusCode);
        }
    }
}
