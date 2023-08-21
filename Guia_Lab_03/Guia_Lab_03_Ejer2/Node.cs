namespace Guia_Lab_03_Ejer2
{
    public class Node
    {
        private Alumno alumno;
        private Node next;

        public Node(Alumno alum)
        {
            this.alumno = alum;
        }

        public void setAlumno(Alumno alum)
        {
            this.alumno = alum;
        }

        public Alumno getAlumno()
        {
            return this.alumno;
        }

        public void setNextAlum(Node node)
        {
            this.next = node;
        }

        public Node getNextAlum()
        {
            return this.next;
        }
    }
}