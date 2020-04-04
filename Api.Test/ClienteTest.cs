using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Cliente;

namespace Tests
{
        
    public class ClienteTest : BaseTest
    {
        [Test]
        public async Task CreateClient()
        {
            var cliente = new Cliente();
            cliente.Nombre = "Benjamin";
            cliente.Apellido = "Lizarraga";
            cliente.CUIL = 20384100229;
            cliente.Email = "lizarraga.jsb@gmail.com";
            cliente.FechaDeNacimiento = new DateTime(1994, 8, 11);
            cliente.DomicilioPersonal = new Domicilio();
            cliente.DomicilioPersonal.Barrio = "Alberdi";
            cliente.DomicilioPersonal.Calle = "Bv San Juan";
            cliente.DomicilioPersonal.Numero = 870;
            cliente.DomicilioPersonal.Depto = "F";
            cliente.DomicilioPersonal.Piso = 4;

            cliente.Trabajos = new List<Trabajo>();
            cliente.Trabajos.Add(new Trabajo()
            {
                Cargo = "Diseñador",
                Sueldo = 2700,
                TelefonoLaboral = 3512485651,
                FechaDeIngreso = new DateTime(2019, 05, 06),
                DomicilioLaboral = new Domicilio()
                {
                    Barrio = "Nueva Córdoba",
                    Calle = "San Lorenzo",
                    Numero = 25,
                    Piso = 6
                },
                LugarDeTrabajo = "La Maquinita Coworking"
            });
            var response = await client.PostAsync("clientes/create", new StringContent(JsonConvert.SerializeObject(cliente), Encoding.UTF8, "application/json"));

            Assert.AreEqual( HttpStatusCode.OK, response.StatusCode);
        }
    }
}
