using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class RetroCheckbox : CheckBox
    {
        public RetroCheckbox()
        {
            IsChecked = true;
            Style = "Retro UI";
        }
        public bool IsChecked { get; set; }
        public string Style { get; set; }
    }
}
