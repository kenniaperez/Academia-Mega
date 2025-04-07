function obtenerUsuario(id){
    try{
        if(typeof id !== "number") throw new Error("El id debe de ser un número");

            const usuarios = {1: "Ana", 2: "Carlos", 3: "Maria"};
            if(!usuarios[id]) throw new Error("Usuario no encontrado");
            console.log(usuarios);
            return `Usuario encontrado: ${usuarios[id]}`;
        
    }catch(error){
        console.error("Error:", error.message );
        return null;
    }
}


console.log(obtenerUsuario(2));
console.log(obtenerUsuario(3));
console.log(obtenerUsuario(1));
console.log(obtenerUsuario(8));
console.log(obtenerUsuario("a"));
console.log(obtenerUsuario("."));
console.log(obtenerUsuario("-3"));


//Almacenamiento interno
console.log("Hola desde el script");

const usuario = {
    nombre: "Ana",
    edad: 30,
    ciudad: "Madrid"
}

const usuarioJson = JSON.stringify(usuario);
console.log("JSON en texto", usuarioJson);

const usuarioObjeto = JSON.parse(usuarioJson);
console.log("JSON en objeto", usuarioObjeto);

localStorage.setItem("usuario", usuarioJson);


//Agregar eventos a los elementos del DOM
document.getElementById("cambiarTexto").addEventListener("click", function(){
    document.getElementById("titulo").textContent = "Texto cambiado con Javascript";
})

document.getElementById("boton").addEventListener("click", function(){
    document.getElementById("resultado").textContent = "Boton clickeado";
})

const hoverTexto =  document.getElementById("hoverTexto");

hoverTexto.addEventListener("mouseover", function(){
    hoverTexto.style.color="red";
})

hoverTexto.addEventListener("mouseout", function(){
    hoverTexto.style.color="black";
})


