Sesión 2: Introducción a JavaScript y Testing

Fecha: 25/03/2025


Objetivos de la Sesión

 - Identificar los tipos de variables para el lenguaje de javascript
 - Identificar Operadores logicos
 - Identificación la sintaxis de algunos tipo de iteracción 


Temas Cubiertos
 1 Estructura de control
	- Variables y constantes (let, const)
	- Operadores aritmeticos
	- Bucles
 


Ejercicios Realizados
Ejercicio 1: 

//Comparación 
// ==, ===, !=, !==, <, >, >=, <=

//Logicos
//&&, ||, !

var edad = 18;

//variables constantes 
 let edad1 = 50;
 const edad2 = 20;

 if(edad<18){
     console.log("Eres menor de edad");
     let dato = "si soy menor de edad";
     var dato2 = "claro que soy menor de edad";
     console.log(dato);
 }else if(edad>= 18 && edad <65){
     console.log("Eres un adulto");
 }else{
     console.log("Eres un adulto mayor");
 }


*****************************************************

 let numero = prompt("Ingresa un numero");
 var letra = (/[a-zA-Z]/).test(numero)
     console.log(letra);
 if(numero>0 && letra == false){
     console.log("El número es positivo");
 }else if(numero<0 && letra == false){
     console.log("El número es negativo");
 }else if(letra == true){
     console.log("Es una letra");
 }
 else{
     console.log("El número es 0")
 }

//*************************************
//Actividad
//*************************************


let intentos = 0;
let claveCorrecta = "1889";
let claveIngresada;
var letra;

while(intentos < 5){
    claveIngresada = prompt("Ingresa la contraseña");
    letra = (/[a-zA-Z]/).test(claveIngresada);
    

    console.log(`Es letra: ${letra}`);
    if(claveIngresada === claveCorrecta && letra === false){
        console.log("Acceso concedido.");
        break;
    }else if(letra === true){
        console.log("La contraseña no puede incluir letras");        
    }else{
        console.log("Contraseña incorrecta");
    }
    intentos ++;
}

if(intentos === 5){
    console.log("Has agotado tus intentos");
}