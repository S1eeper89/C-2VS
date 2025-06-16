using System.Threading.Channels;

namespace C_2_VS_Lekce_8_BR2
{
    public class Obdelnik : IUmiPocitatObsah, IUmiPocitatObvod
    {
        public Obdelnik(int v1, int v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public int V1 { get; }
        public int V2 { get; }

        public void SpocitejObsah(double a, double b)
        {
            double obsah = a * b;

            Console.WriteLine($"Obsah je {obsah}");
        }

        public void SpocitejObvod(double a, double b)
        {
            double obvod = 2 * (a + b);

            Console.WriteLine($"Obsah je {obvod}");
        }
    }

    public class Kruh : IUmiPocitatObsah, IUmiPocitatObvod
    {
        public void SpocitejObsah(double a, double b)
        {
            double obsah = Math.PI * Math.Pow(b, 2);

            Console.WriteLine($"Obsah je {obsah}");
        }

        public void SpocitejObvod(double a)
        {
            double obvod = 2 * Math.PI * a;

            Console.WriteLine($"Obsah je {obvod}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var rect = new Obdelnik(5, 3);
            //napiste dva ruzne interfacy: IUmiPocitatObsah, IUmiPocitatObvod
            //implementujte tridy Obdelnik a Kruh, ktere oba interfacy pouzivaji
            //vlozte jejich instance do seznamu a zavolejte na nich prislusne metody na vypocet obsahu a obvodu        }
        }
    }
}