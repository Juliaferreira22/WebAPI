using Microsoft.AspNetCore.Mvc;

namespace Aula_03.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    class UsuarioController : ControllerBase
    {
        // GET: /api/usuario/listar 
        [HttpGet]
        [Route ("listar")]
        
        public IActionResult Listar()
        {
            return null; 
        }

         [HttpPost]
        public IActionResult Cadastrar()
        {
            return null; 
        }


    }

}