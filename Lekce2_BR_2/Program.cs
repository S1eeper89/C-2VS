using System.Security.Cryptography.X509Certificates;

namespace Lekce2_BR_2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Lucistnik luci = new Lucistnik("Lucifer", 666);

            while (true)
            {
                luci.ShowTheCount();
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1 - Shoot an arrow");
                Console.WriteLine("2 - Add arrows");
                Console.WriteLine("3 - Exit");
                Console.WriteLine("Enter your choice, may your choice be true");

                string choice = Console.ReadLine();

                    switch(choice)
                    {
                        case "1":
                            luci.Shoot();
                            break;

                        case "2":
                            int count = NactiCeleCisloZKonzole("How many arrows would you like to add");
                            luci.AddArrows(count);
                            break;

                        case "3":
                            Console.WriteLine("Exiting the game. Farewell!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please enter 1, 2 or 3");
                            break;
                    }
            }

        }
        public static int NactiCeleCisloZKonzole(string vzyva)
        {
            int number;

            do
            {
                Console.WriteLine("Please enter a valid non-negative integer");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && number >= 0)
                {
                    return number;
                }
                Console.WriteLine($"{input} is not a valid non-negative integer");
            }
            while (true);
            
            
            
        }
    }
}
