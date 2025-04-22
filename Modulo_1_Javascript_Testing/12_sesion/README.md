Sesión 12:Proceso de Testing

Fecha: 08-04-2025


Objetivos de la Sesión

 - Conoce el flujo del testing de software.

Temas Cubiertos
	- Planificación y reporte de pruebas
 
Tipos de errores y defectos:



|   Id  |      Descripción               | Entrada          | Resultado Esperado             |     Resultado Obtenido         |        |
| Prueba|                                |		  		    | 				                 |                                | Estado |
| ----- | ------------------------------ | ---------------- | ------------------------------ | ------------------------------ | ------ |
|  TC01 | Login exitoso con              | Usuario: admin   | Mensaje: "Login exitoso"       | Mensaje: "Login exitoso"       |   OK   |
|       | credenciales validas           | Contraseña: 1234 |								 |							      |        |
|  TC02 | Contraseña incorrecta          | Usuario: admin   | Mensaje: "Usuario o contraseña | Mensaje: "Usuario o contraseña |  ERROR |
|       |                                | Contraseña: 0000 | incorrectos"                   | incorrectos"                   |        |
|  TC03 | Usuario incorrecto             | Usuario: user    | Mensaje: "Usuario o contraseña | Mensaje: "Usuario o contraseña |  ERROR |
|       |                                | Contraseña: 1234 | incorrectos"   			     | incorrectos"                   |        |
|  TC04 | Ambos campos vacios            | Usuario:         | Mensaje: "Todos los campos son | Mensaje: "Todos los campos son |  ERROR |
|       |                                | Contraseña:      | obligatorios"				     | obligatorios"                  |        |
|  TC05 | Solo campo de usuario vacio    | Usuario:         | Mensaje: "Todos los campos son | Mensaje: "Todos los campos son |  ERROR |
|       |                                | Contraseña: 1234 | obligatorios"			         | obligatorios"                  |        |
|  TC06 | Solo campo de contraseña vacio | Usuario: admin   | Mensaje: "Todos los campos son | Mensaje: "Todos los campos son |  ERROR |
|       |                                | Contraseña:      | obligatorios"	     		     | obligatorios"                  |        |
| ----- | ------------------------------ | ---------------- | ------------------------------ | ------------------------------ | ------ |
