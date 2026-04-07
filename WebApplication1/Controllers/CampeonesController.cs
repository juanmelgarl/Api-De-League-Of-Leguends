using AplicattionAPI;
using AplicattionAPI.Common;
using AplicattionAPI.DTOS.Request.Comand;
using AplicattionAPI.DTOS.Request.Query;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using System.Runtime.InteropServices;

namespace WebApplication1.Controllers
{
    [EnableRateLimiting("FixedPorIP")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CampeonesController : ControllerBase
    {
        private readonly IMediator _Mediator;

        public CampeonesController(IMediator mediator)
        {
             _Mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetCampeonesQuery query)
        {
            var result = await _Mediator.Send(query);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpGet("Test")]

        public async Task<IActionResult> TestGlobal()
        {
            throw new Exception("Fallo en el Global exception");
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Obtenerporid([FromRoute] int id)
        {
            var Obtener =  new ObtenerporIdQuery(id);
            var Result = await _Mediator.Send(Obtener);
            if (Result is null)
            {
                return NotFound();
            }
            return Ok(Result);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Borrar = await _Mediator.Send(new DeleteCampeonCommand(id));
            if (Borrar is null)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] CreateCampeonHandlerCommand command)
        {
            var Crear = await _Mediator.Send(command);
            if (Crear is null)
            {
                return NotFound();
            }
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Actualizar(int id,[FromBody]UpdateCampeonCommand command)
        {
            if (id != command.id)
            {
                return BadRequest();
            }

            var Actualizar = await _Mediator.Send(command);
            if (Actualizar is null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
