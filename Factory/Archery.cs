using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Archery : Soldier
    {
        public Archery()
        {
            Name = "Archery";
            HP = 150;
            Damage = 25;
        }
    }
}
