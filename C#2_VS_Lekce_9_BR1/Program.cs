namespace C_2_VS_Lekce_9_BR1
{
    public class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int TelCislo { get; set; }

        public Clovek(string jmeno, string prijmeni, int telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelCislo = telCislo;
        }
    }

    public class Program
    {
        public static void Main()
        {
            var myApplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Console.WriteLine(myApplicationDataPath);

            string reseniUkoluCesta = Path.Combine(myApplicationDataPath, "telefonniSeznam.csv");
            //StreamWriter writer = new StreamWriter(reseniUkoluCesta, append: false);



            List<Clovek> telefonniSeznam = new List<Clovek>
        {
            new Clovek("Jarda", "Kadlec", 777123456),
            new Clovek("Honza", "Kratochvila", 777987654),
            new Clovek("Petr", "Novak", 778111222)
        };

            //var radky = telefonniSeznam.Select


            foreach (var clovek  in telefonniSeznam)
            {
                //File.
            }

            //1. Vytvorte slozku TelefonniSeznam v adresari Appdata pro konkretniho uzivatele
            //2. Do souboru telefonniSeznam.csv ulozte obsah seznamu telefonniSeznam tak,
            //   ze kazdy zaznam bude na jednom radku a oddelene budou carkami
            //3. Napiste cyklus, ktery soubor precte a zpatky ho ulozi do noveho seznamu

            string sixtFile = Path.Combine(myApplicationDataPath, "telefonniSeznamStreamem.csv");
            using (StreamWriter writer1 = new StreamWriter(sixtFile))
            {
                foreach (var clovek in telefonniSeznam)
                {
                    writer1.WriteLine($"{clovek.Jmeno} {clovek.Prijmeni}, {clovek.TelCislo}");
                }
            }

        }
    }
}
