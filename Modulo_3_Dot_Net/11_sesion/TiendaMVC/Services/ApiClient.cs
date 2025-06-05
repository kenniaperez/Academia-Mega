using System.Net.Http.Json;
using TiendaMVC.Models;


namespace TiendaMVC.Services
{
    public class Apiclient
    {
        private readonly HttpClient _http;
        private readonly IHttpContextAccessor _context;

        private Apiclient(HttpClient http, IHttpContextAccessor context)
        {
            _http = http;
            _context = context;

            // si es que hay un token de sessión, lo incluimos en cada petición
            var token = _context.HttpContext!.Session.GetString("JWToken");
            if (!string.IsNullOrEmpty(token)) ;


        }
    }

    public class tokenResponse { public string Token { get; set; } = ""; }
}