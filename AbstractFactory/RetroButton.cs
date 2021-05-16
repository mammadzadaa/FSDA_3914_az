using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class RetroButton : Button
    {
        public RetroButton()
        {
            Text = "OK";
            Style = "Retro UI";
        }
        public string Text { get; set; }
        public string Style { get; set; }
    }
}
