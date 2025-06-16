using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_VS_Lekce_4
{
    public class Knight
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Knight(string name, int health)
        {
            this.Name = name;
            this.Health = health;
        }
        public void WriteNameAndHealth()
        {
            Console.WriteLine($"I am {Name} and I have {Health} lives.");
        }
    }
}
