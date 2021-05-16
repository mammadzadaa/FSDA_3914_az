using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonFactory
{
    class WindowsButton : Button
    {
        public event Action OnClick;

        public void Render()
        {
            Console.WriteLine("Windows Button Rendered");
        }
    }
}
