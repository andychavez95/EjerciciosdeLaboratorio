namespace Guia_Lab_01_Ejer5
{
    public class Lista
    {
        private Nodo inicio = null;
        private int longitud = 0;
        private int suma = 0;

        // Retorna si la lista está vacia o no.
        private bool vacio() { return this.longitud == 0; }

        // Retorna la cantidad total de nodos en la lista.
        public int cantTotal() { return this.longitud; }

        // Retorna la suma de los enteros de los nodos de la lista.
        public int sumElem() { return this.suma; }

        // Inicializa la lista.
        private void insertarPrincipio(int elem)
        {
            Nodo nuevoNodo = new Nodo(elem);
            this.inicio = nuevoNodo;
        }

        // Inserta un nuevo nodo a la lista.
        private void insertarFinal(int elem)
        {
            Nodo nuevoNodo = new Nodo(elem);
            Nodo puntero = this.inicio;
            while (puntero.siguiente != null)
            {
                puntero = puntero.siguiente;
            }
            puntero.siguiente = nuevoNodo;
        }

        // Agrega un elemento a la lista.
        public void agregar(int elem)
        {
            if (this.vacio())
            {
                this.insertarPrincipio(elem);
            }
            else
            {
                this.insertarFinal(elem);
            }
            this.longitud++;
            this.suma = this.suma + elem;
        }

        // Elimina un nodo de la lista.
        public void eliminar(int elem)
        {
            // Si la lista está vacia no hace nada.
            if (this.vacio())
            {
                Console.WriteLine("No hay nada que eliminar. Lista vacia.");
            }
            else
            {
                /*
                 * Dado que en este punto la lista no está vacia buscara
                 * el elemento a eliminar.
                 */
                Nodo puntero = this.inicio;

                // Elimina el nodo inicio de la lista.
                if (puntero.obtElem() == elem)
                {
                    this.inicio = puntero.siguiente;
                    puntero.siguiente = null;
                    Console.WriteLine("Has eliminado el inicio de la lista.");
                    this.longitud--;
                }
                else
                {
                    // Elimina los otros nodos de la lista.
                    int i = 0;
                    /*
                     * Vamos a preguntar si el siguiente nodo de nuestro nodo
                     * actual es el elemento a eliminar. Esto será asi para que
                     * el nodo siguiente del nodo en el que estoy parado apunte
                     * al nodo siguiente del NODO QUE VA A SER ELIMINADO
                     */
                    Nodo puntSig = puntero.siguiente;
                    // Empezamos a buscar desde el segundo nodo.
                    while (i < (this.cantTotal() - 2))
                    {
                        // Validamos si encontramos el nodo a eliminar.
                        if (puntSig.obtElem() == elem)
                        {
                            // El siguiente de mi nodo actual apuntara al 
                            // siguiente de mi nodo a eliminar.
                            puntero.siguiente = puntSig.siguiente;

                            // El siguiente de mi nodo a eliminar ya no apuntara
                            // a nada pues ya no lo necesita.
                            puntSig.siguiente = null;

                            // Si encontramos al nodo, vamos al final de la 
                            // lista para ya no seguir recorriendola.
                            i = this.cantTotal();

                            // Disminiye la cantidad de elementos de la lista.
                            this.longitud--;

                            // Mensaje de elemento eliminado.
                            Console.WriteLine("Elemento " + elem + " eliminado.");
                        }

                        // Si no lo encontramos todavia, vamos al siguiente
                        // nodo de la lista.
                        puntero = puntero.siguiente;
                        puntSig = puntero.siguiente;
                        i++;
                    }
                }
            }
        }

        //Busca un nodo en la lista por su identificador.
        //Retorna una cadena dependiendo de lo que encuentra.
        public string buscNodo(int id)
        {
            //Informa si la lista está vacia.
            if (this.vacio())
            {
                return "la lista está vacia.";
            }
            else
            {
                // Empezamos por el nodo que inicia la lista.
                Nodo puntero = this.inicio;
                int i = 0;

                // Recorremos la lista pero nos apoyaremos con el acumulador
                while (i < this.cantTotal())
                {
                    // Retornamos un mensaje con el nodo encontrado.
                    if (puntero.obtElem() == id)
                    {
                        return "¡elemento encontrado! => " + puntero.obtElem();
                    }
                    //Si no lo encontramos vamos al siguiente.
                    puntero = puntero.siguiente;
                    i++;
                }
                // Si no encontramos el nodo en la lista, lo informamos.
                return "no existe en la lista.";
            }
        }

        public void actuNodo(int id, int nueElem)
        {
            if (this.vacio())
            {
                Console.WriteLine("No hay elementos a actualizar. Lista vacia.");
            }
            else
            {
                bool actualizado = false;
                // Empezamos por el nodo que inicia la lista.
                Nodo puntero = this.inicio;
                int i = 0;

                // Recorremos la lista pero nos apoyaremos con el acumulador
                while (i < this.cantTotal())
                {
                    // Actualizamos la informacion si encontramos al elemento.
                    if (puntero.obtElem() == id)
                    {
                        //Colocamos la nueva información al nodo.
                        puntero.estElem(nueElem);
                        Console.WriteLine("¡Elemento actualizado");
                        actualizado = true;
                        i = this.cantTotal();
                    }
                    //Si no lo encontramos vamos al siguiente.
                    puntero = puntero.siguiente;
                }
                // Si no encontramos el nodo en la lista, lo informamos.
                if (!actualizado)
                {
                    Console.WriteLine("El elemento no existe en la lista.");
                }
            }
        }

        //Obtiene los pares e impares de la lista enlazada.
        public void obtenerParImpar()
        {
            if (this.vacio())
            {
                Console.WriteLine("La lista no tiene nodos.");
            }
            else
            {
                Nodo puntero = this.inicio;
                int i = 0;
                while (i < this.cantTotal())
                {
                    if ((puntero.obtElem() % 2) == 0)
                    {
                        Console.WriteLine("Par: " + puntero.obtElem());
                    }
                    else
                    {
                        Console.WriteLine("Impar: " + puntero.obtElem());
                    }
                    i++;
                    puntero = puntero.siguiente;
                }
            }
        }

        //Imprime la lista completa
        public void imprimirLista()
        {
            Nodo puntero = this.inicio;
            int i = 0;

            Console.WriteLine("************************************");
            while (i < this.cantTotal())
            {
                Console.WriteLine(puntero.obtElem());
                i++;
                puntero = puntero.siguiente;
            }
            Console.WriteLine("************************************");
        }
    }
}
