using System.Linq.Expressions;
using System.Numerics;

namespace C_2_VS_Lekce_2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 50;
            
            Calculator calculator = new Calculator();

            try
            {
                Console.WriteLine($"Result is: {calculator.DivideTwoNumbers(number1, number2)}");
                //Calculator.DivideTwoNumbers(number1, number2);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Calculator has ben called");
            }
        }

        private static void ExceptionsExample()
        {
            // Get two numbers and divide them

            int number1 = 0;
            int number2 = 0;

            try
            {
                System.Console.WriteLine("Insert first number");
                string input = Console.ReadLine();
                number1 = int.Parse(input);

                System.Console.WriteLine("Insert first number");
                input = Console.ReadLine();
                number2 = int.Parse(input);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Number for dividing is expected. String was inserted instead");
                Console.ReadLine();
                return;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine($"Wrong user input. Your universe will be terminated");
                Console.ReadLine();
                return;
            }





            Console.WriteLine($"Resullt is: {number1 / number2}");
        }

        private static void DateTimeExample()
        {
            Rytir albrecht = new Rytir("Albrecht", 10);
            //albrecht.IntroduceYourself();

            //albrecht.DateOfBirth / DateTime.now
            albrecht.DateOfBirth = new DateTime(1970, 10, 5);
            albrecht.DateOfBirth = albrecht.DateOfBirth.AddHours(10).AddMinutes(25);

            Console.WriteLine($"I am Born at: {albrecht.DateOfBirth}");

            TimeSpan vek = DateTime.Now - albrecht.DateOfBirth;
            TimeSpan cas = new TimeSpan(10, 10, 10);

            Console.WriteLine(cas);

            System.Console.WriteLine($"Im {vek.Days / 365} years old.");

            System.Console.WriteLine($"Im {vek.TotalDays / 365} years old.");

            //Console.ReadLine();
        }
    }
    
}
