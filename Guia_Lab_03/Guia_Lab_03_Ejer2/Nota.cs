namespace Guia_Lab_03_Ejer2
{
    public class Nota
    {
        private float calificacion;
        private float peso;

        public Nota(float calif, float peso)
        {
            this.calificacion = calif;
            this.peso = peso;
        }

        public float getCalPes()
        {
            return this.calificacion * peso;
        }

        public float getPeso()
        {
            return this.peso;
        }
    }
}
