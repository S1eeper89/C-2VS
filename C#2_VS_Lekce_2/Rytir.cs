using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_VS_Lekce_2
{
    public class Rytir
    {
        // create a name and number of lifes 
        // create a constructor
        // create a date of birth

        public string Name { get; set; }
        public int NumberOfLifes { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Rytir(string name, int numberOfLifes ) //DateTime dateOfBirth
        {
            Name = name;
            NumberOfLifes = numberOfLifes;
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {Name} and I have {NumberOfLifes} number of lifes.");
        }
    }
}
