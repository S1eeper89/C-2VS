using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_VS_Lekce_8
{
    public abstract class MagicHuman: Human
    {
        public override void IntroduceYourself()
        {
            Console.WriteLine("Magic");
        }
        public abstract void BecomeInvisible();

        public abstract void BecomeVisible();

    }
}
