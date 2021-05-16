using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Cannon : Soldier
    {
        public Cannon()
        {
            Name = "Cannon";
            HP = 300;
            Damage = 150;
        }
    }
}
