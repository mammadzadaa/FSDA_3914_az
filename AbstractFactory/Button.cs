using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface Button
    {
        public string Text { get; set; }
        public string Style { get; set; }
    }
}
