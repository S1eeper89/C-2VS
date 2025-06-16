using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace C_2_VS_Lekce_8
{
    public class Prince : DancingHumans
    {
        public override void IntroduceYourself()
        {
            Console.WriteLine("I am a Prince");
        }
        public override void StartDancing()
        {
            Console.WriteLine("tancuji princ");
        }
        public override void StopDancing()
        {
            Console.WriteLine("dotancoval jsem princ");
        }
    }
}
