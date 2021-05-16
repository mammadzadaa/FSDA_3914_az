using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Swardsman : Soldier
    {
        public Swardsman()
        {
            Name = "SwardsMan";
            HP = 200;
            Damage = 15;
        }
    }
}
