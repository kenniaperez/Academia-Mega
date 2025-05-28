using Microsoft.AspNetCore.Mvc;
using TiendaMVC.Models;
using System.Collections.Generic;
using TiendaMVC.Services;
using System.Threading.Tasks;

namespace TiendaMVC.Controlers
{
    public class ProductosController : Controller
    {
        // private static readonly List<Producto> _productos = new()
        // {
        //     new Producto { Id = 1, Nombre = "Xiomi 15 Ultra", Precio = 33000.00m},
        //     new Producto { Id = 2, Nombre = "HONOR Magic 7 Pro", Precio = 33000.00m}
        // };
        
        //Inyección de dependencias
        private readonly IProductoApiService _api;
        public ProductosController(IProductoApiService api) => _api = api;

        //GET /Productos
        public async Task<IActionResult> Index()
        {
            var products = await _api.GetAllAsync();
            return View(products);
        }

        //GET Productos
        // public IActionResult Create() => View();

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Create(Producto producto)
        // {
            
        // }

        public IActionResult Details(int id)
        {
             return View(new Producto());
            // var product = _productos.FirstOrDefault(p => p.Id == id);
            // if (product == null)
            //     return NotFound();
            //return View(product);
        }
    }
}