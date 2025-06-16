using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_VS_Lekce_8
{
    public class Fairy : DancingHumans, IMagicHuman
    {
        public void BecomeInvisible()
        {
            Console.WriteLine("Fairy is invisible");
        }


        public void BecomeVisible()
        {
            Console.WriteLine("Fairy is visible");
        }
        
        public override void IntroduceYourself()
        {
            Console.WriteLine("I am Fairy");
        }

        public override void StartDancing()
        {
            Console.WriteLine("Fairy is dancing");
        }

        public override void StopDancing()
        {
            Console.WriteLine("Fairy stopped dancing");
        }
    }
}
