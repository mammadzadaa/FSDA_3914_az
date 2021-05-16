using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class UIToolKit_AbstractFactory
    {
        public abstract Button CreateButton();
        public abstract CheckBox CreateCheckBox();
    }
}
