// See https://aka.ms/new-console-template for more information
using System;

class Program
{

    private static Dictionary<string, string> usuarios = new Dictionary<string, string>{
        {"admin", "qwerty"},
        {"usuario", "123"},
        {"user", "mega"}
    };

    static void Main(string[] args){

        //Mensaje de bienvenida
        Console.WriteLine("Hola mundo, aqui  desde C#");
        Console.WriteLine("Tienes que iniciar sesión");

        //Definir el usuario y la contraseña
        string usuarioCorrecto = "admin"; 
        String passCorrecta = "qwerty"; 

        Console.WriteLine("Escribe tu usuario");
        String? usuarioIngresado = Console.ReadLine(); 
        Console.WriteLine("Escribe tu contraseña");
        String? passIngresada = Console.ReadLine();

        if (usuarioIngresado != null){
             if(usuarios.ContainsKey(usuarioIngresado)  && usuarios[usuarioIngresado]== passIngresada){
                Console.WriteLine("Has ingresado con exito");
                for(int i = 1;  i <= 50; i++){
                    Console.WriteLine($"{i}. Hola Usuario, gracias y eres lo maximo!!!");
                }
                Console.WriteLine("\n Presiona enter para salir del programa...");
                Console.WriteLine();
            }
            else{
                Console.WriteLine("Usuario o contraseña incorrecta");
                Console.WriteLine("\n Presiona enter para salir del programa...");
                Console.WriteLine();
            }
        }

       
    }
}