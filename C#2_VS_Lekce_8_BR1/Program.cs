namespace C_2_VS_Lekce_8_BR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PohadkovaBytost arabela = new Princezna();
            PohadkovaBytost artus = new Rytir();
            PohadkovaBytost hedwika = new Carodenice();

            List<PohadkovaBytost> pohadkoveBytosti = new List<PohadkovaBytost> { arabela, artus, hedwika };

            foreach (PohadkovaBytost pb in pohadkoveBytosti)
            {
                pb.NapisJakTravisVolnyCas();
            }

            pohadkoveBytosti[0].NapisJakTravisVolnyCas();
            // Vytvorte instance od kazde tridy a vypiste informace o trávení volného času.
        }
    }
}
