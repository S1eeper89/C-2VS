namespace C_2_VS_Lekce_4_BR_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Vytvorte tridu TelefonniSeznam
- uvnitr ni budete ukladat dvojice Jmeno - Telefonni cislo
- k tomu pouzijte Dictionary, jehoz klice budou stringy a hodnoty integery
- v ramci konstruktoru vyplnte nekolik jmen a cisel
- vytvorte metodu, ktera do slovniku ulozi noveho cloveka a jeho telefonni cislo
- vytvorte metodu, ktera vrati telefonni cislo cloveka
- vytvorte metodu, ktera vypise cely telefonni seznam
- vytvorte metodu, ktera smaze daneho cloveka
- vytvorte metodu, ktera smaze cely telefonni seznam .Clear()
- myslete na mozne chybove stavy (co kdyz tam dany clovek neni, co kdyz pridavam cloveka, ktery uz tam je)
- napiste kratky program, ktery overi funkcnost teto tridy */



        }
    }
    public class TelefonniSeznam
    {
        private Dictionary<string, int> seznam = new Dictionary<string, int>();

        public TelefonniSeznam()
        {
            // Předvyplněná data
            seznam["Jan Novák"] = 608456789;
            seznam["Petra Malá"] = 608654321;
            seznam["Karel Horák"] = 608222333;
            seznam["Lucie Dvořáková"] = 608555666;
        }

    }

}
