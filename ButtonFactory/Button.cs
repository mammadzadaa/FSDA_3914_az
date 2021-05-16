using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonFactory
{
    interface Button
    {
        public void Render();
        public event Action OnClick;
    }
}
