using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FlatUI : UIToolKit_AbstractFactory
    {
        public override Button CreateButton()
        {
            return new FlatButton();
        }

        public override CheckBox CreateCheckBox()
        {
            return new FlatCheckbox();
        }
    }
}
