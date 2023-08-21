using System.Collections.Generic;

namespace Guia_Lab_03_Ejer2
{
    public class Alumno
    {
        private string nombre;
        private LinkedList<Nota> listNotas;
        private float promPonderado = 0;

        public Alumno(string nombre)
        {
            this.nombre = nombre;
            this.listNotas = new LinkedList<Nota>();
        }

        public void addNota(Nota nota)
        {
            this.listNotas.AddLast(nota);
        }

        public void setPromPonderado()
        {
            // Partes de la fracción.
            float numerador = 0;
            float denominador = 0;

            // Recorremos la lista de notas que tiene el alumno.
            foreach (Nota nota in listNotas)
            {
                numerador += nota.getCalPes();
                denominador += nota.getPeso();
            }

            // División entre la suma de las calificaciones y sus pesos
            // y la suma de los pesos.
            this.promPonderado = numerador / denominador;
        }

        public float getPromPonderado()
        {
            return this.promPonderado;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }
    }
}
