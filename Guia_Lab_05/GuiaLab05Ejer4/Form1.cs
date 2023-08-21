namespace GuiaLab05Ejer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string executableDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(executableDirectory).Parent.Parent.FullName;
            string pathFile = projectDirectory + @"\NumPrimos.txt";

            string[] numPrimos = File.ReadAllLines(pathFile);

            string output = "";

            foreach (string num in numPrimos)
            {
                output = output + num + "\r" + "\n";
            }
        }
    }
}