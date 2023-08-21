/*
 *  Genere un programa en C# que permita ingresar vía teclado dos números enteros. 
 * El programa deberá calcular:
 *   a. La suma de ambos números
 *   b. La resta de ambos números
 *   c. El producto de ambos números
 *   d. La división de ambos números
 *   e. La potenciación de ambos números (X^Y).
 */

using System.Diagnostics.CodeAnalysis;

Console.Write("Ingrese un primer número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese un primer número: ");
int num2 = int.Parse(Console.ReadLine());

int sum, resta, multi;
double div, poten;

Console.WriteLine("=============================");
sum = num1 + num2;
Console.WriteLine("La suma de {0} y {1} es {2}", num1, num2, sum);

Console.WriteLine("=============================");
resta = num1 - num2;
Console.WriteLine("La resta de {0} y {1} es {2}", num1, num2, resta);

Console.WriteLine("=============================");
multi = num1 * num2;
Console.WriteLine("La multiplicación de {0} y {1} es {2}", num1, num2, multi);

Console.WriteLine("=============================");
div = Convert.ToDouble(num1) / num2;
Console.WriteLine("La división de {0} y {1} es {2}", num1, num2, div);

Console.WriteLine("=============================");
poten = Math.Pow(num1, num2);
Console.WriteLine("La potencia de {0} elevado al exponente {1} es {2}", num1, num2, poten);
