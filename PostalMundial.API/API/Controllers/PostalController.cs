using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostalController : ControllerBase, IPostalController
    {
        private readonly IPostalFlujo _postalFlujo;
        private readonly ILogger<PostalController> _logger;

        public PostalController(IPostalFlujo postalFlujo, ILogger<PostalController> logger)
        {
            _postalFlujo = postalFlujo;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Agregar([FromBody] PostalRequest postal)
        {
            var resultado = await _postalFlujo.Agregar(postal);
            return CreatedAtAction(nameof(Obtener), new {Id=resultado}, null);
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Editar([FromRoute] Guid Id, [FromBody] PostalRequest postal)
        {
            var resultado = await _postalFlujo.Editar(Id, postal);
            return Ok(resultado);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Eliminar([FromRoute] Guid Id)
        {
            var resultado = await _postalFlujo.Eliminar(Id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            var resultado = await _postalFlujo.Obtener();
            return Ok(resultado);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid Id)
        {
            var resultado = await _postalFlujo.Obtener(Id);
            return Ok(resultado);
        }

        [HttpGet("faltantes")]
        public async Task<IActionResult> ObtenerFaltantes()
        {
            var resultado = await _postalFlujo.ObtenerFaltantes();
            return Ok(resultado);
        }
    }

}