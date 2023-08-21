using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_ESDAT_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo rutasCiudades = new Grafo();
            rutasCiudades.agregarRuta("Lima", "Ica",301);
            rutasCiudades.agregarRuta("Lima", "Chiclayo",769);
            rutasCiudades.agregarRuta("Chiclayo", "Trujillo", 211);
            rutasCiudades.agregarRuta("Ica", "Moquegua",794);

            rutasCiudades.imprimirRutas();
            Console.ReadLine();
        }
    }
}
