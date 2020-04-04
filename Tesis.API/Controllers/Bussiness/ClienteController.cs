using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tesis.Bussiness.Definition;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.API.Controllers.Bussiness
{
    [Route("clientes")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = false)]
    public class ClienteController : Controller
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            await this.clienteService.Save(cliente);
            return Ok();
        }

        [Route("update")]
        [HttpPost]
        public async Task<IActionResult> Update(Cliente cliente)
        {
            await this.clienteService.Save(cliente);
            return Ok();
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            await this.clienteService.Delete(id);
            return Ok();
        }
    }
}
