using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_06_06_21
{
    class Car
    {
        public int Id { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public float EngineSize { get; set; }
        public override string ToString()
        {
            return $"{Vendor} {Model} {HorsePower} {EngineSize}";
        }
    }
}
