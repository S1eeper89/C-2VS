using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_VS_Lekce_8
{
    internal class Wizard : Human, IMagicHuman
    {

        public override void IntroduceYourself()
        {
            Console.WriteLine("I am a Wizard");
        }
        public void BecomeVisible()
        {
            Console.WriteLine("Jsem viditeln7 kouyeln9k");
        }

        public void BecomeInvisible()
        {
            Console.WriteLine("Jsem viditelny kouzelnik");
        }
    }
}

