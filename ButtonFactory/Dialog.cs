using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonFactory
{
    abstract class Dialog
    {
        public void Render() { }
        public abstract Button CreateButton();
    }
}
