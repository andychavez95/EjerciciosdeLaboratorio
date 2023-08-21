namespace Guia_Lab_03_Ejer2
{
    public class ListEnlSimp
    {
        private Node inicio;
        private int length = 0;

        // Me dice si la lista está vacia o no
        private bool isEmpty() { return this.length == 0; }

        public int getLength() { return this.length; }

        // Insertar al principio
        public void insertarInicio(Alumno alum)
        {
            // Inserta al inicio solo si la lista está vacia
            if (this.isEmpty())
            {
                // Instanciamos un objeto Nodo
                Node newNode = new Node(alum);

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
                Node newNode = new Node(alum);

                // El siguiente del nuevo nodo es el nodo inicio de la lista
                // actualmente.
                newNode.setNextAlum(p);

                // Luego el inició de la lista es el nuevo nodo.
                this.inicio = newNode;
            }
            this.length++;
        }

        // Insertar al final de la lista.
        public void insertarFinal(Alumno alum)
        {
            // Inserta al inicio solo si la lista está vacia.
            if (this.isEmpty())
            {
                // Instanciamos un objeto Nodo.
                Node newNode = new Node(alum);

                // Agregamos el nodo al inicio de la lista.
                // Ahora el inicio de la lista apunta al nodo creado.
                this.inicio = newNode;
            }
            else
            {
                // Resguardamos el inicio de la lista.
                Node p = this.inicio;

                // Instanciamos un objeto Nodo.
                Node newNode = new Node(alum);

                // Si el siguiente al nodo donde estoy parado es null
                // significa que ya he llegado al final de la lista.
                while (p.getNextAlum() is not null)
                {
                    p = p.getNextAlum();
                }

                p.setNextAlum(newNode);
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
                    Console.WriteLine("Nombre: " + p.getAlumno().getNombre());
                    Console.WriteLine("Promedio ponderado: " + p.getAlumno().getPromPonderado());
                    p = p.getNextAlum();
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
                this.inicio = p.getNextAlum();
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
                while (p.getNextAlum().getNextAlum() is not null)
                {
                    p = p.getNextAlum();
                }
                p.setNextAlum(null);
                this.length--;
            }
        }
    }
}
