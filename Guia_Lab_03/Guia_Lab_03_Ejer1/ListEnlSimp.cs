namespace Guia_Lab_03_Ejer1
{
    public class ListEnlSimp
    {
        private Node inicio;
        private int length = 0;

        // Me dice si la lista está vacia o no
        private bool isEmpty() { return this.length == 0; }

        public int getLength() { return this.length; }

        // Insertar al principio
        public void insertarInicio(int elem)
        {
            // Inserta al inicio solo si la lista está vacia
            if (this.isEmpty())
            {
                // Instanciamos un objeto Nodo
                Node newNode = new Node(elem);

                // Agregamos el nodo al inicio de la lista.
                // Ahora el inicio de la lista apunta al nodo creado.
                this.inicio = newNode;
            }
            else
            {
                // Si la lista no está vacia tenemos que actualizar el 
                // inicio de la lista.

                // Vamos a resguardar el inicio de la lista antes de hace 
                // la actualización.
                Node p = this.inicio;

                // Creamos un objeto Nodo con el elemento a insertar.
                Node newNode = new Node(elem);

                // El siguiente del nuevo nodo es el nodo inicio de la lista
                // actualmente.
                newNode.setNextNode(p);

                // Luego el inició de la lista es el nuevo nodo.
                this.inicio = newNode;
            }
            this.length++;
        }

        // Insertar al final de la lista.
        public void insertarFinal(int elem)
        {
            // Inserta al inicio solo si la lista está vacia.
            if (this.isEmpty())
            {
                // Instanciamos un objeto Nodo.
                Node newNode = new Node(elem);

                // Agregamos el nodo al inicio de la lista.
                // Ahora el inicio de la lista apunta al nodo creado.
                this.inicio = newNode;
            }
            else
            {
                // Resguardamos el inicio de la lista.
                Node p = this.inicio;

                // Instanciamos un objeto Nodo.
                Node newNode = new Node(elem);

                // Si el siguiente al nodo donde estoy parado es null
                // significa que ya he llegado al final de la lista.
                while (p.getNextNode() is not null)
                {
                    p = p.getNextNode();
                }

                p.setNextNode(newNode);
            }
            this.length++;
        }

        // Imprime los elementos de la lista.
        public void mostrar()
        {
            if (this.isEmpty())
            {
                Console.WriteLine("La lista está vacia.");
            }
            else
            {
                Node p = this.inicio;

                do
                {
                    Console.WriteLine("Elemento: " + p.getElemNode());
                    p = p.getNextNode();
                } while (p is not null);
            }
        }

        // Elimina el nodo inicio de la lista.
        public void eliminarInicio()
        {
            if (this.isEmpty())
            {
                Console.WriteLine("La lista está vacia. No hay nada que borrar.");
            }
            else
            {
                Node p = this.inicio;
                this.inicio = p.getNextNode();
                this.length--;
            }
        }

        // Elimina el nodo final de la lista.
        public void eliminarFinal()
        {
            if (this.isEmpty())
            {
                Console.WriteLine("La lista está vacia. No hay nada que borrar.");
            }
            else if (this.getLength() == 1)
            {
                this.inicio = null;
                this.length--;
            }
            else
            {
                Node p = this.inicio;
                while (p.getNextNode().getNextNode() is not null)
                {
                    p = p.getNextNode();
                }
                p.setNextNode(null);
                this.length--;
            }
        }
    }
}
