using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FlatCheckbox : CheckBox
    {
        public FlatCheckbox()
        {
            IsChecked = true;
            Style = "Flat UI";
        }
        public bool IsChecked { get; set; }
        public string Style { get; set; }
    }
}
