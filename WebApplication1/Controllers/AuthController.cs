using AplicattionAPI.Common;
using AplicattionAPI.DTOS.Request.Comand;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator) => _mediator = mediator;

        [HttpPost("LOGIN")]
        public async Task<IActionResult> Login([FromBody] LoginCommand command)
        {
            var token = await _mediator.Send(command);
            if (!token.IsSuccess)
            {
                return Unauthorized(token.IsFailure);
            }
           
            return Ok(new { Token = token.Value});
        }
    }
}