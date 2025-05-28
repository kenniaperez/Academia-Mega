using System.Net.Http.Json;
using TiendaMVC.Models;
using TiendaMVC.Services;

namespace TiendaMVC.Services
{
    public class ProductoApiService : IProductoApiService
    {
        private readonly HttpClient _http;
        //Crear constructor e inicializar el Http
        public ProductoApiService(HttpClient http) => _http = http;
        public async Task<List<Producto>> GetAllAsync() =>
            await _http.GetFromJsonAsync<List<Producto>>("api/productos") ?? new List<Producto>();

        // public async Task<Producto?> CreateAsync(Producto p)
        // {
        //     var response = await _http.PostAsJsonAsync("api/products", p);
        //     if (!response.IsSuccessStatusCode) return null;
        //     return await response.Content.ReaaFromJsonAsync<Producto>();
        //     //await _http.GetFromJsonAsync<List<Producto>>("api/producto") ?? new List<Producto>();
        // }

    }
}