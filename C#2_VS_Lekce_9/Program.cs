using Microsoft.VisualBasic;

namespace C_2_VS_Lekce_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("mzFirstFile.txt", "My first content.");

            string secondFile = @"C:\Git\C-2VS\C#2_VS_Lekce_9\obj\Debug\net8.0\SecondFile.txt";
            File.WriteAllText(secondFile, "My second content");

            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(myDocumentsPath);

            string thirdFile = Path.Combine(myDocumentsPath, "ThirdFile.txt");
            Console.WriteLine(thirdFile);

            File.WriteAllText(secondFile, $"My third content, in {myDocumentsPath}");
            File.WriteAllText(thirdFile, "My third content second");

            string fourthFile = Path.Combine(myDocumentsPath, "FourthFile.txt");
            StreamWriter writer = new StreamWriter(fourthFile, append: false);

            writer.WriteLine("FirstLine");
            writer.WriteLine("SecondLine");
            writer.WriteLine("ThirdLine");
            writer.Flush();
            writer.WriteLine("MagicLine");
            writer.WriteLine("Evil Line");
            writer.WriteLine("Diagonal alley");
            writer.Close();


            string[] lines = File.ReadAllLines(fourthFile);
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

            string pathToDirectory = Path.Combine(myDocumentsPath, "FifthFile.txt");
            File.WriteAllText(pathToDirectory, "Mysecond second content");

            if (Directory.Exists(pathToDirectory))
            {
                File.WriteAllText(pathToDirectory, "test test if pro zapis");
            }
            if()
            {

            }

        }
    }
}
