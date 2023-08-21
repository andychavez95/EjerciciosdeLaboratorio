namespace Guia_Lab_01_Ejer5
{
    public class Nodo
    {
        public int elemento;
        public Nodo siguiente = null;

        public Nodo(int elemento)
        {
            this.elemento = elemento;
        }

        public int obtElem()
        {
            return this.elemento;
        }

        public void estElem(int nueElem)
        {
            this.elemento = nueElem;
        }
    }
}
