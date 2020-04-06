using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Bussiness.Definition;
using Tesis.Models.Dominio.Credito;

namespace Tesis.API.Controllers.Bussiness
{
    [Route("Creditos")]
    [ApiController]
    public class CreditoController : Controller
    {
        private readonly ICreditoService creditoService;

        public CreditoController(ICreditoService creditoService)
        {
            this.creditoService = creditoService;
        }

        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> Create(Credito credito)
        {
            await creditoService.Save(credito);
            return Ok();
        }

        [Route("approve/{id}")]
        [HttpPost]
        public async Task<IActionResult> Approve([FromRoute] string id)
        {
            return null;
        }


        [Route("cancel/{id}")]
        [HttpPost]
        public async Task<IActionResult> Cancel([FromRoute] string id)
        {
            return null;
        }

        [Route("payquotas/{id}")]
        [HttpPost]
        public async Task<IActionResult> PayQuotas([FromRoute] string id)
        {
            return null;
        }
    }
}
