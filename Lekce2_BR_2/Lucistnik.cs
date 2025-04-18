using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce2_BR_2
{
    public class Lucistnik
    {
        public string Name { get; set; }
        public int AmountOfArrows { get; set; }

        public Lucistnik(string name, int amountOfArrows)
        {
            Name = name;
            AmountOfArrows = amountOfArrows;
        }

        public void Shoot()
        {
            if(AmountOfArrows > 0)
            {
                AmountOfArrows -= 1;
                Console.WriteLine($"Congratz, you hit the trarget! You have {AmountOfArrows} arrows remaining.");
            }
            else
                Console.WriteLine("Sorry buddy, not enough arrows!");
        }

        public void AddArrows(int count)
        {
            if (count>0)
            {
                AmountOfArrows += count;
                Console.WriteLine($"You added to your quiver {count} arrows, currently you have {AmountOfArrows} arrows, let's hope none are blank.");
            }
            else
                Console.WriteLine("This is no proper way how to add arrows you have to stay positive while adding arrows!");
        }

        public void ShowTheCount()
        {
            Console.WriteLine($"Your bowman named {Name} has {AmountOfArrows} in his quiver, bow before his bow and quiver with fear, coz his aim is clear");
        }

    }
}
