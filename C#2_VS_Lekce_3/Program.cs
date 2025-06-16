using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace C_2_VS_Lekce_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello!";
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("a" + "b");
            Console.WriteLine('a' + 'b');
            Console.WriteLine("Int a: " + (int)'a');
            Console.WriteLine((char)('A' + 35));
            Console.WriteLine("=============");
            Console.WriteLine(new string('=', 10));

            string input = Console.ReadLine();
            if (input == null || input.Length == 0)
            {
                Console.WriteLine("not good");
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("IsNullorWhiteSpace works");
            }
            Console.WriteLine(string.Equals("ahoj", "Ahoj"));
            Console.WriteLine(string.Equals("ahoj", "Ahoj", StringComparison.OrdinalIgnoreCase));


            // druha cast

            string text = "Hello, my name is Martin an I am very happy.";

            Console.WriteLine(text.Contains("Martin"));

            Console.WriteLine(text.Contains("Martin", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(text.IndexOf("Martin"));
            Console.WriteLine(text.IndexOf("Martin", 19));

            string martin = text.Substring(18, 6);
            Console.WriteLine(martin);
            Console.WriteLine(text.Replace("Martin", "Josef"));

            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Name must not be empty!");
            }
            Console.WriteLine($"This person is called {name}");
            Console.WriteLine($"This person is called {name.Trim()}.");


            string[] words = new string[] { "kajak", "program", "rotor", "Czechitas" };
            foreach (var word in words)
            {
                Console.WriteLine($"{word.PadRight(20, '.')} {word.Length}");
            }

            Console.WriteLine("Give me 4 names (delimited by a space):");
            string names = Console.ReadLine();
            string[] namesAsArray = names.Split(" ");
            if (namesAsArray.Length < 4)
            {
                throw new Exception("I wanted 4!!!");
               
            }


            foreach (var word in words)
            {
                Console.WriteLine($"{word.PadRight(20, '.')} {word.Length}");
            }

        }
    }
}
