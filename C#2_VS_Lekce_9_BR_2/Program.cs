using System.Collections.Generic;
using System.Xml.Serialization;

namespace C_2_VS_Lekce_9_BR_2
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
            List<Clovek> telefonniSeznam = new List<Clovek>
        {
            new Clovek("Jarda", "Kadlec", 777123456),
            new Clovek("Honza", "Kratochvila", 777987654),
            new Clovek("Petr", "Novak", 778111222)
        };

            //1. Upravte tridu Clovek, aby byla serializovatelna
            //2. Ulozte cely telefonni seznam do XML pomoci serializeru a StreamWriteru
            XmlSerializer serializer = new XmlSerializer(typeof(List<Clovek>));
            using StreamWriter writer = new StreamWriter("XmlFile.xml");
            serializer.Serialize(writer, telefonniSeznam);
            writer.Close();
            //3. Nactete cely telefonni seznam ze souboru XML pomoci deserializeru a StreamReaderu
            using StreamReader reader = new StreamReader("Xml");
            var fileContent = (List<Clovek>)

            // 3. Deserializace seznamu ze souboru
            List < Clovek > nactenySeznam;
            using (StreamReader reader = new StreamReader("XmlFile.xml"))
            {
                nactenySeznam = (List<Clovek>)serializer.Deserialize(reader);
            }

            // Výpis načtených dat na konzoli
            Console.WriteLine("Načtený seznam kontaktů:");
            foreach (var clovek in nactenySeznam)
            {
                Console.WriteLine($"{clovek.Jmeno} {clovek.Prijmeni}, Tel: {clovek.TelCislo}");
            }

        }
    }
}
