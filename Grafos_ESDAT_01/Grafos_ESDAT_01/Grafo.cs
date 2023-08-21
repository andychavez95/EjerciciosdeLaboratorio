using System.Collections;

namespace Grafos_ESDAT_01
{
    internal class Grafo
    {
        private Dictionary<string, List<string>> listaAdyacentes;
        //listaAdyacentes corresponde a las relaciones que existen entre nodos
        //string (Key) => índice (nombres de las personas que conforman la red social)
        //List<string> (Value) => lista de amigos de cada usuario de la red social
        public Grafo()
        {
            listaAdyacentes = new Dictionary<string, List<string>>();
            //inicializa la listaAdyacentes (en este caso relaciones de amistad)
        }
        
        public void agregarAmistad(string persona1, string persona2)
        {
            //establece una relación de amistad entre los usuarios persona1 y persona2
            //agregar a persona1 a la lista de adyacentes de persona2
            //agregar a persona2 a la lista de adyacentes de persona1
            if (!listaAdyacentes.ContainsKey(persona1)) 
                listaAdyacentes[persona1] = new List<string>();
            //si no existe la lista de adyacentes de persona1, la creamos
            if (!listaAdyacentes.ContainsKey(persona2))
                listaAdyacentes[persona2] = new List<string>();
            //si no existe la lista de adyacentes de persona2, la creamos

            listaAdyacentes[persona1].Add(persona2);
            //agregamos a la lista de adyacentes de persona1 a persona2
            listaAdyacentes[persona2].Add(persona1);
            //agregamos a la lista de adyacentes de persona2 a persona1
        }

        public void mostrarAmigos()
        {
            //Mostrar los amigos (el contenido de la lista de adyacentes)
            //de un usuario de la red social
            foreach(KeyValuePair<string, List<string>> persona in listaAdyacentes)
            {
                Console.WriteLine(persona.Key + " es amigo de:");
                //Key se refiere al índice del diccionario
                foreach(string amigo in persona.Value) //Value es la lista de amigos
                {
                    Console.Write(amigo + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
