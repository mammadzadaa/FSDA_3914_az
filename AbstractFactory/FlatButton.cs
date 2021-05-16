using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FlatButton : Button
    {
        public FlatButton()
        {
            Text = "Click ME";
            Style = "Flat Design";
        }
        public string Text { get; set; }
        public string Style { get; set; }
    }
}
