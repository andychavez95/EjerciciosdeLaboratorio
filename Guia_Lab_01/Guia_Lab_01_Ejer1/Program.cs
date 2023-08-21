/*
 * Desarrolle un programa en C# que permita el ingreso de dos números enteros y los 
 * compare. El programa deberá indicar cuál es el número mayor (o si son iguales, 
 * indicarlo)
 */

Console.WriteLine("Ingrese un primer número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese un primer número: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2) {
    Console.WriteLine("Los números son iguales.");
}
else if (num1 > num2) {
    Console.WriteLine("El primero número es mayor.");
}
else {
    Console.WriteLine("El segundo número es mayor.");
}
