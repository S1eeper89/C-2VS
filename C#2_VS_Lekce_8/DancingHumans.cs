using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_VS_Lekce_8
{
    public abstract class DancingHumans : Human
    {
        public override void IntroduceYourself()
        {
            Console.WriteLine("Dancing");
        }
        public abstract void StartDancing();
        
        public abstract void StopDancing();
       
    }
}
