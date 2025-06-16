namespace Lekce_3_BR_1
{
    public class Program
    {
        static bool JePalindrom(string slovo)
        {
            slovo = slovo.ToLower(); // převedeme na malá písmena kvůli case-insensitive porovnání

            for (int i = 0; i < slovo.Length / 2; i++)
            {
                // porovnání znaku zleva a zprava
                if (slovo[i] != slovo[slovo.Length - 1 - i])
                {
                    return false; // jakmile se jeden pár neshoduje, není to palindrom
                }
            }
            return true;
        }
        public static void Main()
        {

            //Ukol - Obratte poradi stringu
            string palindrom = "Kuna nese nanuk";
            for (int i = 0; i < length; i++)
            {
                bool isPalindrom = string.Compare(palindrom[i], (char)palindrom[(int)(-1) - 1(-i)]);
            }

        Úkol: Otočit string a porovnat ho s originálem
            string palindrom = "Kuna nese nanuk";
            string reversed = "";

            // Procházení stringu od konce a sestavení obrácené verze
            for (int i = palindrom.Length - 1; i >= 0; i--)
            {
                reversed += palindrom[i];
            }

            // Výpis původního a obráceného textu
            Console.WriteLine("Původní text: " + palindrom);
            Console.WriteLine("Obrácený text: " + reversed);

            // Převod obou stringů na malá písmena
            string originalLower = palindrom.ToLower();
            string reversedLower = reversed.ToLower();

            // Porovnání původního a obráceného řetězce
            bool isPalindrom = (originalLower == reversedLower);

            Console.WriteLine("Je to palindrom (včetně mezer a velikosti písmen)? " + (isPalindrom ? "Ano" : "Ne"));




            //Ukol - Napiste funkci, ktera umi detekovat, ze se jedna o palindrom (zatim jen u slov) a pak z pole vypiste jen palindromy
            string[] slova = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };
            
            int delka = slova.Length;
            for (int i = 0; i < delka; i++)
            {
                if (JePalindrom(slova[i]))
                {
                    Console.WriteLine($"Slovo {slova[i]} je palindrom");
                }
            }

            //Ukol - opravte v tomto textu omylem zapnuty Caps Lock
            string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";

            char[] opraveny = new char[text.Length];

            //Ukol - rozsifrujte tuto zpravu - text byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
            string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";


        }
    }
}