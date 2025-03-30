Sesión 2: Introducción a JavaScript y Testing

Fecha: 26/03/2025


Objetivos de la Sesión

 - Aprender a declarar funciones
 - Identificar tipos de funciones
 - Identificación el alcance de las variables dentro o fuera de funciones


Temas Cubiertos
 1 Funciones de Javascript
	- Declaración de funciones
	- Funciones de flecha y anónimas.
	- Scope y closures
 


Ejercicios Realizados
Ejercicio 1: 

//Closure

function contador(){
    let cuenta =0;
    return function(){
        cuenta ++;
        return cuenta;
    };
}

const incrementar = contador();
console.log(incrementar());//1
console.log(incrementar());//2
console.log(incrementar());//3



*****************************************************

Ejercicio 2:

//Crea una función que devuelva otra función que multiplica

function multiplicador(factor){
    return function(numero){
        return numero * factor;
    }
}

const cuadruplicar = multiplicador(4);
const  octuple = multiplicador(8);

console.log(cuadruplicar(10));
console.log(octuple(10));