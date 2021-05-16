using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    static class FactoryMethod
    {
        public static Soldier GetSoldier(string solderType)
        {
            if (solderType == "A")
            {
                return new Archery();
            }
            if (solderType == "S")
            {
                return new Swardsman();
            }
            if (solderType == "C")
            {
                return new Cannon();
            }
            return null;
        }
    }
}
