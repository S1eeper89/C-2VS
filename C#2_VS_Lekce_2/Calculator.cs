using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_VS_Lekce_2
{
    internal class Calculator
    {
        // divide two nubmers
        // if second number is zero., throw an excepoption.
        public double DivideTwoNumbers(int a, int b)
        {
            // if user would like to divide bz yero, thrrow an exception
            if (b == 0)
            {
                throw new ArgumentException("Divide by zero is not supported");
            }
            return a / b;
        }
    
}
}
