using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tesis.API.Controllers.Bussiness
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "hello world!";
        }
    }
}