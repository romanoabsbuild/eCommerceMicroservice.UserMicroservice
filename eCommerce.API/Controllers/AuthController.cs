using eCommerce.Core.DTO;
using eCommerce.Core.ServicesContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest registerRequest) 
        {
            // Verificar o registerRequest
            if(registerRequest == null) 
            {
                return BadRequest("Dados de registo inválidos");
            }

            // Registar o user
            AuthenticationResponse? authenticationResponse = await _userService.Register(registerRequest);

            if (authenticationResponse == null || authenticationResponse.Success == false) 
            {
                return BadRequest(authenticationResponse);
            }

            return Ok(authenticationResponse);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest) 
        {
            if (loginRequest == null) 
            {
                return BadRequest("Dados de login inválidos");
            }

           AuthenticationResponse? authenticationResponse = await _userService.Login(loginRequest);

            if (authenticationResponse == null || authenticationResponse.Success == false) 
            {
                return Unauthorized(authenticationResponse);
            }

            return Ok(authenticationResponse);

        }
    }
}
