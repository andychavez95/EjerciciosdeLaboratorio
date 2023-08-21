using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_ESDAT_02
{
    internal class Grafo
    {   //cada grafo representa a una ciudad
        //se requiere indicar las rutas (conexiones) existentes entre
        //ciudades y además el distancia (peso) de dicha conexión
        private Dictionary<string, Dictionary<string,int>> listaAdyacentes;

        public Grafo()
        {
            listaAdyacentes = new Dictionary<string, Dictionary<string,int>>();
        }

        public void agregarRuta(string ciudad1, string ciudad2, int distancia)
        {
            if(!listaAdyacentes.ContainsKey(ciudad1))
                listaAdyacentes[ciudad1] = new Dictionary<string, int>();
            if (!listaAdyacentes.ContainsKey(ciudad2))
                listaAdyacentes[ciudad2] = new Dictionary<string, int>();

            listaAdyacentes[ciudad1][ciudad2] = distancia;
            listaAdyacentes[ciudad2][ciudad1] = distancia;
        }

        public void imprimirRutas()
        {
            foreach(var ciudad in listaAdyacentes){
                Console.WriteLine(ciudad.Key + " tiene rutas directas a: ");
                //ciudad.key indica la ciudad de origen
                foreach(var ruta in ciudad.Value) //ciudad.Value indica las ciudades que están 
                                                //conectadas con la ciudad de origen
                {
                    Console.WriteLine(ruta.Key + " (distancia: " + ruta.Value + "km)");
                    //ruta.key indica la ciudad de destino
                    //ruta.value indica la distancia entre ciudades
                }
                Console.WriteLine("\n");
            }
        }
    }
}
