using System;
using System.Collections.Generic;
using System.Text;

namespace DapperApp
{
    class Car
    {
        public int Id { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public double EngineSize { get; set; }
        public Owner Owner { get; set; }
    }
}
