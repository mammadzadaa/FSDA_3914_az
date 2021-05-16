using System;

namespace ButtonFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select App type 'W' for Windows and 'H' for HTML:");
            string selection = Console.ReadLine();
            Dialog d = null;
            if (selection == "W")
            { 
                d = new WindowsDialog();
            }
            else if(selection == "H")
            {
                d = new HTMLDialog();
            }

            Button b = d.CreateButton();
            b.Render();
        }
    }
}
