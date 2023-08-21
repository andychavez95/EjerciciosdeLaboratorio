using System.Collections;
using System.Reflection;

namespace GuiaLab05Ejer3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            string executableDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(executableDirectory).Parent.Parent.FullName;

            string pathFile = projectDirectory+@"\NumPrimos.txt";

            string[] numPrimos = File.ReadAllLines(pathFile);

            foreach (string num in numPrimos)
            {
                q.Enqueue(int.Parse(num));    
            }

            while (q.Count > 0)
            { 
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
