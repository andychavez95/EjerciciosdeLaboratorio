namespace Guia_Lab_03_Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpta;
            string nombreAlum;
            float calif, peso;

            ListEnlSimp l = new ListEnlSimp();

            do
            {
                // Ingresa el nombre del alumno.
                Console.WriteLine("Ingrese el nombre del alumno: ");
                nombreAlum = Console.ReadLine();

                Alumno a = new Alumno(nombreAlum);

                do
                {
                    // Ingresa las calificaciones de las notas.
                    Console.WriteLine("Ingrese la calificación: ");
                    calif = float.Parse(Console.ReadLine());

                    // Ingresa el peso que le corresponde a la calificación.
                    Console.WriteLine("Ingrese el peso de la calificación: ");
                    peso = float.Parse(Console.ReadLine());

                    Nota n = new Nota(calif, peso);

                    a.addNota(n);

                    // Pregunta si desea ingresar más notas.
                    // Solo se acepta s o S.
                    Console.WriteLine("¿Desea ingresar más notas?. Responda con [s/S]");
                    rpta = Console.ReadLine();

                } while (rpta.Equals("s") || rpta.Equals("S"));
                a.setPromPonderado();
                l.insertarFinal(a);

                // Pregunta si desea ingresar más alumnos.
                // Solo se acepta s o S.
                Console.WriteLine("¿Desea ingresar más alumnos?. Responda con [s/S]");
                rpta = Console.ReadLine();
            } while (rpta.Equals("s") || rpta.Equals("S"));

            l.mostrar();
        }
    }
}
