namespace C_2_VS_Lekce_7_BR_1
{
    public abstract class Zviratko
    {
        public abstract void VydavejZvuk();
    }
    public class Pes : Zviratko
    {
        public override void VydavejZvuk()
        {
            Console.WriteLine("Haf, haf!");
        }
    }
    public class Kocka : Zviratko
    {
        public override void VydavejZvuk()
            {
            Console.WriteLine("Mnau, mnau");
        }
    }
    public class Kralik : Zviratko
    {
        public override void VydavejZvuk()
        {
            Console.WriteLine("Píí, píí");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Zviratko> zooKoutek = new List<Zviratko>();

            zooKoutek.Add(new Pes());
            zooKoutek.Add(new Kocka());
            zooKoutek.Add(new Kralik());

            foreach (Zviratko zvire in zooKoutek)
            {
                zvire.VydavejZvuk();
            }
        }
    }
}
