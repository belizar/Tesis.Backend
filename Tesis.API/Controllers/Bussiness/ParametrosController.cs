using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Bussiness.Definition;
using Tesis.Models.Dominio.Credito;

namespace Tesis.API.Controllers.Bussiness
{
    [Route("parametros")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = false)]
    public class ParametrosController : Controller
    {
        private readonly IParametrosService parametrosService;

        public ParametrosController(IParametrosService parametrosService)
        {
            this.parametrosService = parametrosService;
        }

        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> Post(Parametros entity)
        {
            await this.parametrosService.Save(entity);
            return Ok();
        }

    }
}
