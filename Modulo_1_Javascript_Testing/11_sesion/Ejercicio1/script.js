document.getElementById("testForm").addEventListener("submit", function(e){
    e.preventDefault(); // Evita el comportamiento por defecto del dormulario

    const nombre = document.getElementById("nombre").value.trim();
    const edad = document.getElementById("edad").value.trim();
    const resultado = document.getElementById("resultado");

    console.log(nombre,edad)

    try{
        validarDatos(nombre,edad);
    }catch(error){
        console.log("error: ", error)
        resultado.textContent = error.message
        resultado .style.color = "red"
    }

})


function validarDatos(nombre, edad){
    console.log("Validando datos...");

    if(!nombre || !edad <= 0){
        throw new Error("Por favor completa todos los datos");
    }
    if (edad <= 0){
        throw new Error ("La edad debe ser un numero valido");
    }
    if (nombre.length > 30){
        throw new Error ("El nombre es demasiado largo");
    }

    console.log("Datos validado correctamente");

}

