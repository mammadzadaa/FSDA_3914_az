using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class Soldier
    {
        public int HP { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacking and damaging {Damage} point");
        }
        public void Defend()
        {
            Console.WriteLine($"{Name} Defending and has health {HP} point");
        }

    }
}
