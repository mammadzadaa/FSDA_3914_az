﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface CheckBox
    {
        public bool IsChecked { get; set; }
        public string Style { get; set; }
    }
}
