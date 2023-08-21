using System;

namespace Guia_Lab_01_Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista m = new Lista();
            int id, nueElem;

            //Agregando elementos a la lista.
            m.agregar(2);
            m.agregar(3);
            m.agregar(5);
            m.agregar(13);
            m.agregar(20);
            m.agregar(67);
            m.agregar(9);

            //Imprime los nodos de la lista.
            m.imprimirLista();

            // Imprime la cantidad de elementos de la lista.
            Console.WriteLine("# de elementos: " + m.cantTotal());

            // Busca un elemento de la lista.
            Console.Write("Ingrese el elemento que busca: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Buscando elemento..." + m.buscNodo(id));

            // Solicita el id del elemento a eliminar.
            Console.Write("Ingrese el identificador del elemento a eliminar: ");
            id = int.Parse(Console.ReadLine());

            // Busca y elimina el id del elemento de la lista.
            m.eliminar(id);

            Console.WriteLine("Buscando elemento..." + m.buscNodo(id));
            Console.WriteLine("# de elementos: " + m.cantTotal());

            // Solicita un nodo a actualizar.
            Console.Write("Ingrese el identificador del elemento a actualizar: ");
            id = int.Parse(Console.ReadLine());

            // Solicita la información a actualizar.
            Console.Write("Ingrese el nuevo valor para el elemento: ");
            nueElem = int.Parse(Console.ReadLine());

            m.actuNodo(id, nueElem);

            m.imprimirLista();
        }
    }
}
