namespace C_2_VS_Lekce_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight borivoj = new Knight() { Name = "Borivoj", Health = 100 };
            Knight vojtech = new Knight() { Name = "Vojtech", Health = 100 };
            Knight miroslav = new Knight() { Name = "Miroslav", Health = 80 };
            Knight bronislav = new Knight() { Name = "Bronislav", Health = 50 };
            Knight vaclav = new Knight() { Name = "Vaclav", Health = 80 };
            Knight radovan = new Knight() { Name = "Radovan", Health = 10 };

            List<Knight> knights = new List<Knight>() { borivoj, vojtech, miroslav, bronislav, vaclav, radovan };

            var strongKnights = knights.Where(knight => knight.Health > 90);
            var weakKnights = knights.Where(isWeak);

            foreach (var k in strongKnights)
            {
                System.Console.WriteLine($"{k.Name}");
            }

            foreach (var k in weakKnights)
            {
                System.Console.WriteLine($"{k.Name}");
            }
            System.Console.WriteLine("---------");


            var strongKnightsNames = knights.Where(knight => knight.Health > 90).Select(k => k.Name);
            foreach (var name in strongKnightsNames)
            {
                System.Console.WriteLine($"{name}");
            }

            // Count
            System.Console.WriteLine($"Number of strong knights: {strongKnightsNames.Count()}");
            System.Console.WriteLine($"Number of strong knights: {knights.Count(k => k.Health > 90)}");

            System.Console.WriteLine(" FIRST/LAST SECTION");
            System.Console.WriteLine($"First knight in list is: {knights.First().Name}");
            System.Console.WriteLine($"Last knight in list is: {knights.Last().Name}");

            var emptyList = knights.Where(k => k.Health > 150);

            Knight knight = emptyList.FirstOrDefault();

            Knight? knight1 = emptyList.FirstOrDefault();
            if (knight is not null)
            {
                System.Console.WriteLine($"First knight in list is: {knight.Name}");
            }
            else
            {
                System.Console.WriteLine("Knight is not present");
            }
            //System.Console.WriteLine($"First knight in list is: {emptyList.First().Name}");

            // multiple filters
            System.Console.WriteLine("-------- Multiple filters ---   ");
            var filteredKnights = knights.Where(knight => knight.Health > 60);

            foreach (var k in filteredKnights)
            {
                System.Console.WriteLine(k.Name);
            }
            System.Console.WriteLine("-------- Additional M filter ---   ");
            var filteredKnightsStartsByM = filteredKnights.Where(k => k.Name.Contains("ori"));
            foreach (var k in filteredKnightsStartsByM)
            {
                System.Console.WriteLine(k.Name);
            }

            Console.WriteLine($"Is there stronger knight than 200HP? {knights.Any(k => k.Health > 200)}");
            Console.WriteLine($"Is there stronger knight than 90HP? {knights.Any(k => k.Health > 90)}");
            Console.WriteLine($"Does all knights has 90HP or more? {knights.All(k => k.Health > 90)}");
            Console.WriteLine($"Arr all knights allive? {knights.All(k => k.Health > 1)}");
            Console.WriteLine($"What is the minimum health? {knights.Min(k => k.Health)}");
            Console.WriteLine($"What is the average health? {knights .Average(k => k.Health)}");


        }

        private static bool isWeak(Knight knight)
        {
            return knight.Health < 20;
        }


    }


    class Knight
    {
        public string Name { get; set; }
        public int Health { get; set; }
    }
}
