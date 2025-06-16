namespace C_2_VS_Lekce_7
{
    public class Person
    {
        public string Name { get; set; }
        public void PrintMyName()
        {
            Console.WriteLine($"My name is {Name}");
        }
    }
    public class Hero : Person
    {
        public int Health { get; set; } = 10;
    }
    public class Witch : Person
    {

    }
    internal class Program
        
       
    {
        static void Main(string[] args)
        {

            Hero hero = new Hero();
            hero.Name = "Heralt";
            hero.Health = 11;

            //Person person

            Witch siri = new Witch();
            siri.Name = "Siri";
            List<Hero> heroes = new List<Hero>();
           // List<Person> heroes = new List<Person>();
            heroes.Add(hero);
           // heroes.Add(person);
            //Witch.Add(siri);

            foreach (var h in heroes)
            {
                if (h is Witch)
                {
                    Witch witch = (Witch)h;
                }
            }


        }

    }
}
