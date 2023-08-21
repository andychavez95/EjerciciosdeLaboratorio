/*
 * Genere un programa en C# que permita ingresar dos números (límite superior y 
 * límite inferior) y muestre en pantalla los números comprendidos en dicho 
 * intervalo. UFlice un bucle while
 */

Console.WriteLine("Ingrese el límite superior: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el límite inferior: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("=============================");
while (num2 <= num1) {
    Console.WriteLine(num2++);
}
Console.WriteLine("=============================");
