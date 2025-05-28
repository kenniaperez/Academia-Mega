using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using PrimeraAPI.Data;
using PrimeraAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace PrimeraAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly UsuariosService _usuaioService;

        private readonly IConfiguration _config;

        public AuthController(UsuariosService usuarioService, IConfiguration config)
        {
            _usuaioService = usuarioService;
            _config = config;
        }

        [HttPost("registro")]
        public async Task<IActionResult> Register() {
            var ok = await _usuaioService.RegistroAsync(UserLogin.Username, UserLogin.Password);
            if (!ok) return Conflict(new { message = "El usuario ya existe" });
            var token = GenerateToken(username.Username);
            return Ok(new { Token });
        }
        private string GenerateToken(string username)
        {
            var key = Encoding.ASCII.GetBytes(_config["JwtKey"]!);
            var claims = new[] {
                new Claim(ClaimTypes.Name, username)
        };


            var credentials = new SigningCredentials(new SymmetricSecuritykey(key), SecurityAlgorithms.HmacSha256);

            var jwt = new JwtSecurityToken(
                claims: claims,
                expires: DataTime.UtcNow.AddHour(2),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(jwt);


        }
    }

    public class UserLogin {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
    }
}