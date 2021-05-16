﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonFactory
{
    class HTMLDialog : Dialog
    {
        public override Button CreateButton()
        {
            return new HTMLButton();
        }
    }
}
