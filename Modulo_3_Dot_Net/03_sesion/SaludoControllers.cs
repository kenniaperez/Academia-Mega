using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

[ApiController]
[Route("[controller]")]

public class SaludoController : ControllerBase {
    //GET /saludo
    [HttpGet]
    public IActionResult Get(){
        return Ok(new { mensaje = "Hola desde el SaludoContrtoller"});
    }//tipo de dato clase


    //GET /saludo/{name}
    [HttpGet("personalizado/{nombre}")]
    public IActionResult GetPersonalizado(string nombre){
        var respuesta = new{
            mensaje = $"Holaaa, {nombre}"
        };

        return Ok(respuesta);
    }

    
}