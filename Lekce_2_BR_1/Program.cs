using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Lekce_2_BR_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zbyvajici dny do dovolene
            // Postupne se uzivatele zeptej na den, mesic a rok odjezdu na dovolenou. Pomoci DateTime a TimeSpan vypocitej pocet
            // zbyvajicich dni do odjezdu na dovolenou a vypis je na konzoli.
            // Pozn.: pro zjednoduseni staci pouzit int.Parse

            Console.WriteLine("Zadej prosím den odjezdu na dovolenou");
            string vstupDen = Console.ReadLine();
            int.TryParse(vstupDen, out int den);

            Console.WriteLine("Zadej prosím mesic odjezdu na dovolenou");
            string vstupMesic = Console.ReadLine();
            int.TryParse(vstupMesic, out int mesic);

            Console.WriteLine("Zadej pros9m rok odjezdu na dovolenou");
            string vstupRok = Console.ReadLine();
            int.TryParse(vstupRok, out int rok);

            DateTime odjezd = new DateTime(rok, mesic, den);
            TimeSpan casOdjezdu = odjezd - DateTime.Now;
            //TimeSpan denOdjezdu = (365 - odjezd); 

            Console.WriteLine($"");
            Console.WriteLine($" Odjedes za {casOdjezdu.Days} dni");
            Console.ReadLine();
        }
    }
}
