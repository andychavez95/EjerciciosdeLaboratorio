using Grafos_ESDAT_01;

class Program
{
    public static void Main(string[] args)
    {
        Grafo redSocial = new Grafo();

        redSocial.agregarAmistad("Luis", "Carmen");
        redSocial.agregarAmistad("Luis", "Angel");
        redSocial.agregarAmistad("Carmen", "Esther");
        redSocial.agregarAmistad("Angel", "Esther");

        redSocial.mostrarAmigos();

    }
}
