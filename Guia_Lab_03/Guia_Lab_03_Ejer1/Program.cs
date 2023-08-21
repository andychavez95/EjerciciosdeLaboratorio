using System;

namespace Guia_Lab_03_Ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListEnlSimp l = new ListEnlSimp();
            // Agregar elementos a la lista.
            l.insertarInicio(1);
            l.insertarFinal(3);
            l.insertarInicio(4);
            l.insertarFinal(5);

            // Imprimir la longitud de la lista.
            Console.WriteLine("La longitud de la lista es: " + l.getLength());

            // Imprimir todos los elementos de la lista.
            l.mostrar();

            // Elimina el nodo inicial de la lista.
            l.eliminarInicio();

            // Imprimir la longitud de la lista.
            Console.WriteLine("La longitud de la lista es: " + l.getLength());

            // Imprimir todos los elementos de la lista.
            l.mostrar();

            // Elimina el nodo final de la lista.
            l.eliminarFinal();

            // Imprimir la longitud de la lista.
            Console.WriteLine("La longitud de la lista es: " + l.getLength());

            // Imprimir todos los elementos de la lista.
            l.mostrar();
        }
    }
}
