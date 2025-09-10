// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Armando Urvina!");
int altura = 178;
int edad = 27;
string nombre = "Armando Urvina";
string informacion = "nacio en cocle, y es estudiante de desarrollo de software e jugador profesional";
var hobby = "leer manhwas";



string tarjetaDeIdentificacion = $"La informacion de {nombre} es la siguiente \n Su edad es {edad}\n"+$"su altura es {altura}cms\n Informacion relevante {informacion} \n su hobby es{hobby} ";

Console.WriteLine(tarjetaDeIdentificacion);