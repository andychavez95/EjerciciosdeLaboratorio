namespace Guia_Lab_01_Ejer4
{
    internal class Persona
    {
        private String nombre;
        private int edad;
        private String profesion;

        public Persona(String nombre, int edad, String profesion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.profesion = profesion;
        }

        public String getNombre() { return this.nombre; }
        public int getEdad() { return this.edad; }
        public String getProfesion() { return this.profesion; }

        public void saludar()
        {
            Console.WriteLine("Hola soy {0}. Tengo {1} años y mi profesión es {2}.", this.getNombre(), this.getEdad(), this.getProfesion());
        }
    }
}
