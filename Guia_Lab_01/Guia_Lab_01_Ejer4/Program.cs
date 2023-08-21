/*
 *  Genere un programa en C# orientado a objetos que permita crear una clase 
 * Persona. La clase tendrá los siguientes atributos: nombre, edad, profesión. El 
 * programa principal deberá crear un objeto de la clase Persona solicitando los datos 
 * mencionados vía teclado.
 */
using Guia_Lab_01_Ejer4;

String nombre, profesion;
int edad;

Console.Write("Ingrese su nombre: ");
nombre = Console.ReadLine();

Console.Write("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine());

Console.Write("Ingrese su profesión: ");
profesion = Console.ReadLine();

Persona miPersona = new Persona(nombre, edad, profesion);

miPersona.saludar();
