using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonFactory
{
    class HTMLButton : Button
    {
        public event Action OnClick;

        public void Render()
        {
            Console.WriteLine("HTML Button Rendered");
        }
    }
}
