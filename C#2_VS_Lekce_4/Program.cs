using System.Runtime.CompilerServices;

namespace C_2_VS_Lekce_4
{
    
    internal class Program
    {
      
        static void Main(string[] args)
        {
            {
                //listSession();

                Dictionary<string, string> dict = new Dictionary<string, string>
                {
                    { "car", "auto" },
                    { "dog", "pes" },
                    { "phone", "telefon" }
                };

                Console.WriteLine($"English word dog is in cyech {dict["dog"]}");

                dict.Add("watch", "hodinky");
                dict["cup"] = "pohar";

                if(dict.TryGetValue("dog", out string dogInCzech))
                {
                    Console.WriteLine($"English word dog is in czech {dogInCzech}");
                }

                foreach (string key in dict.Keys)
                {
                    Console.WriteLine($"English word key is in czech {dict[key]}");

                    foreach (KeyValuePair<string, string> keyValuePair in dict)
                    {
                        Console.WriteLine($"English word{keyValuePair.Key} is in czech {keyValuePair.Value}");
                    }

                    foreach (var keyValuePair in dict)
                    {
                        Console.WriteLine($"English word{keyValuePair.Key} is in czech {keyValuePair.Value}");
                    }

                    var newDictionary = new Dictionary<string, int>
                    {
                        {"Martin", 100 },
                        {"Zuzka", 120 },
                        {"Artus", 100 }
                    };

                    var dogString = "pes";
                    var myNumber = 0.0;

                    newDictionary.Remove("Martin");

                    foreach(var knight in newDictionary)
                    {
                        new Knight(knight.Key, knight.Value).WriteNameAndHealth();
                    }

                    Dictionary<string, List<string>> advancedDictionary = new Dictionary<string, List<string>>
                    {
                        { "bat", new List<string> {"netopyr", "palka"} }
                    };

                    foreach(var keyValuePair in advancedDictionary)
                    {
                        Console.WriteLine($"English word{keyValuePair.Key} can be: {string.Join(" ", keyValuePair.Value)}");
                    }
                }
                
            }



            Knight martin = new Knight("Martin", 100);
            Knight zuzka = new Knight("Zuzka", 120);
            Knight artus = new Knight("Artus", 100);

            Knight[] knights = new Knight[] { martin, zuzka, artus };

            for (int i = 0; i < knights.Length; i++)
            {
                knights[i].WriteNameAndHealth();
            }
            Console.WriteLine();
            Knight jan = new Knight("Jan", 80);
            knights.Append(jan);

            for (int i = 0; i < knights.Length; i++)
            {
                knights[i].WriteNameAndHealth();

            }
            Console.WriteLine();

            // Knight[] -> array
            // List<Knight> -> list
            List<Knight> knightsList = new List<Knight> { martin, zuzka, artus };

            for (int i = 0; i < knights.Length; i++)
            {
                knights[i].WriteNameAndHealth();

            }
            Console.WriteLine();

            knightsList.Add(jan);

            foreach (Knight knight in knightsList)
            {
                knight.WriteNameAndHealth();
            }
            Console.WriteLine();

            int indexOfArtus = knightsList.IndexOf(artus);
            knightsList.RemoveAt(indexOfArtus);
            //  knightsList.Remove(artus);

            foreach (Knight knight in knightsList)
            {
                knight.WriteNameAndHealth();
            }
            Console.WriteLine();

            knightsList.Insert(1, artus);

            foreach (Knight knight in knightsList)
            {
                knight.WriteNameAndHealth();
            }
            Console.WriteLine();

            if (knightsList.Contains(artus))
            {
                Console.WriteLine("Yes he's here");
            }
            else
            {
                Console.WriteLine("No, he's not here");
            }
            Console.WriteLine($"Artus is at index {knightsList.IndexOf(artus)}");
            knightsList.RemoveAt(knightsList.IndexOf(artus));

            Knight knightNamedMartin = knightsList.Find(k => k.Name == "Martin");

            if (knightNamedMartin == null)
            {
                throw new Exception("Not found");
            }

            knightNamedMartin.WriteNameAndHealth();


            //knightsList.Sort();
            ////string.Compare(CompareKnights);
            //Muzeme si to i rozepsat, mozna je to jasnejsi: 
            //knightsList.Sort((k1, k2) => CompareKnights(k1, k2));




        }
        private static int CompareKnights(Knight knight1, Knight knight2)
        {
            return string.Compare(knight1.Name, knight2.Name);
        }
    }
}
