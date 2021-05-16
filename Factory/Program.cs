using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Swardsman press 'S' for Archery press 'A' and for Cannon press 'C':");
            string selection = Console.ReadLine();
            Soldier s = FactoryMethod.GetSoldier(selection);
         
            s?.Attack();
            s?.Defend();
        }
    }
}
