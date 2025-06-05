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
        private readonly ApiClient _api;
        public ProductosController(ApiClient api) => _api = api;

        //GET /Productos
        public async Task<IActionResult> Index()
        {
            var products = await _api.GetProductosAsync();
            return View(products);
        }

        //GET Productos
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Producto producto)
        {
            if (!ModelState.IsValid) return View(producto);

            var created = await _api.CreateProductoAsync(producto);
            if (created == null)
            {
                ModelState.AddModelError("", "Error al crear el producto");
                return View(producto);
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _api.GetByIdProductosAsync(id);
            if (product == null) return NotFound();
            return View(product);

                //return View(new Producto());
                // var product = _productos.FirstOrDefault(p => p.Id == id);
                // if (product == null)
                //     return NotFound();
                //return View(product);
        }

        //GET /Productos/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _api.GetByIdProductosAsync(id);
            if (product == null) return NotFound();
            return View(product);
        }

        // POST /Productos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Producto producto)
        {
            if (id != producto.Id) return BadRequest();
            if (!ModelState.IsValid) return View(producto);

            var ok = await _api.UpdateProductoAsync(id, producto);
            if (!ok)
            {
                ModelState.AddModelError("", "Error al actualizar el producto");
                return View(producto);
            }
             return RedirectToAction(nameof(Index));
        }

        // // DELETE /Productos/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _api.DeleteProductoAsync(id);
            if (product == null) return NotFound();
            //return View(product);
            return RedirectToAction(nameof(Index));
        }

                // DELETE /Productos/Delete/5
                // [HttpPost]
                // [ValidateAntiForgeryToken]
                // public async Task<IActionResult> Delete(int id)
                // {
                //     if (id != producto.Id) return BadRequest();
                //     //if (!ModelState.IsValid) return View(producto);

                //     var ok = await _api.DeleteAsync(id);
                //     if (!ok)
                //     {
                //         ModelState.AddModelError("", "Error al eliminar el producto");
                //         return View(producto);
                //     }
                //     return RedirectToAction(nameof(Index));
                // }
    }
}