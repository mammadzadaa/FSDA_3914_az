using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your UI Toolkit, 'R' for Retro and 'F' for flat:");
            string choice = Console.ReadLine();
            UIToolKit_AbstractFactory abstractFactory = null;

            if (choice == "R")
            {
                abstractFactory = new RetroUI();
            }
            else if (choice == "F")
            {
                abstractFactory = new FlatUI();
            }

            Console.WriteLine(abstractFactory.CreateButton().Style);
        }
    }
}
