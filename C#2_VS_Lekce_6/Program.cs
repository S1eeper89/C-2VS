namespace C_2_VS_Lekce_6
{
    class Knight
    {
        public string Name;

        private int Strength;

        private int Health;

        public Knight (string name)
        {
            this.Name = name;
            this.Strength = 20;
            this.Health = 100;
        }

        public Knight(string name, int strength, int health)
        {
            this.Name = name;
            this.Strength = strength;
            this.Health = health;
        }

        public void DefendYourself(Knight attacker)
        {

        }
        public void GetHealth(Knight healt)
        {
            healt.Name += healt;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var geralt = new Knight("Geralt");
            geralt.Name = "geralt";
            geralt.Strength = 100;
            var artus = new Knight("Artus");

            Console.WriteLine(geralt.Health);
            geralt.DefendYourself(artus);
            Console.WriteLine(geralt.Health);


        }
    }
}
