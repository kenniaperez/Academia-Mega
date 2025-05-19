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

        //Aqu´í sería la lectura de datos en BD
        private readonly ProductoService _service;
        public ProductosController(ProductoService service)
        {
            _service = service;
        }

        /*
            -CREATE-
        */

        [HttpPost]// POST /api/productos
        public ActionResult<Producto> Create(Producto nuevo)
        {
            return NoContent();
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
        public ActionResult<Producto> GetById(int id)
        {
            return NoContent();
            // var product = _datos.FirstOrDefault(p => p.id == id);
            // if (product == null) return NotFound();
            // return Ok(product);
        }

        /*
            -UPDATE-
        */
        [HttpPut("{id}")]// PUT /api/productos/1
        public IActionResult Update(int id, Producto actualizado)
        {
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
        public IActionResult Delete(int id)
        {
            return NoContent();
            // var product = _datos.FirstOrDefault(p => p.id == id);
            // if (product == null) return NotFound();

            // _datos.Remove(product);
            // return Ok("El valor se ha eliminado correctamente");


        }
    }


}

