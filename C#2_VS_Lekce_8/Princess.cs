using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_VS_Lekce_8
{
    internal class Princess : DancingHumans
    {
        public override void IntroduceYourself()
        {
            Console.WriteLine("I am a Princess");
        }
        public override void StartDancing()
        {
            Console.WriteLine("tancuji princezna");
        }
        public override void StopDancing()
        {
            Console.WriteLine("dotancoval jsem princezna");
        }
    }
}
