using Microsoft.AspNetCore.Mvc;
using PrimeraAPI.Data;
using PrimeraAPI.Models;
//using Asp.Versioning;

namespace PrimeraAPI.Controllers
{ 
    [ApiController]
    //[ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]

    public class ProductosController : ControllerBase
    {

        //Aquí sería la lectura de datos en BD
        private readonly ProductoService _service;
        public ProductosController(ProductoService service)
        {
            _service = service;
        }


        /*
            -CREATE-
        */

        [HttpPost]// POST /api/productos
        public async Task<IActionResult> Create(Producto nuevo)
        {
            var created = await _service.CreateAsync(nuevo);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
           //return NoContent();
            // nuevo.id = _datos.Max(p => p.id) + 1;
            // _datos.Add(nuevo);
            // return CreatedAtAction(nameof(GetById), new { id = nuevo.id }, nuevo);
        }

        /*
            -READ-
        */
        [HttpGet]//GET  /api/productos
        public async Task<IActionResult>GetAll()
        {
            var lista = await _service.GetAllAsync();
            return Ok(lista);
        }

        [HttpGet("{id}")] //GET /api/productos/1
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            if (product == null) return NotFound();
            return Ok(product);
            // var product = _datos.FirstOrDefault(p => p.id == id);
            // if (product == null) return NotFound();
            // return Ok(product);
        }

        /*
            -UPDATE-
        */
        [HttpPut("{id}")]// PUT /api/productos/1
        public async Task<IActionResult> Update(int id, Producto actualizado)
        {
            var updated = await _service.UpdateAsync(id, actualizado);
            if (!updated) return NotFound();
            return NoContent();
            // var product = _datos.FirstOrDefault(p => p.id == id);
            // if (product == null) return NotFound();

            // product.Nombre = actualizado.Nombre;
            // product.Precio = actualizado.Precio;

            // return NoContent();
        }

        /*
        -DELETE-
    */
        [HttpDelete("{id}")]// DELETE /api/productos/1
        public async Task<IActionResult> Delete(int id)
        {
             var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
            // var product = _datos.FirstOrDefault(p => p.id == id);
            // if (product == null) return NotFound();

            // _datos.Remove(product);
            // return Ok("El valor se ha eliminado correctamente");


        }
    }


}

