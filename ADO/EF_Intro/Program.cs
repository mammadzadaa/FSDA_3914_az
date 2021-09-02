using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CarsDbContext db = new CarsDbContext())
            {
                var cars = db.Cars;
                foreach (var c in cars)
                {
                    Console.WriteLine($"{c.Vendor} {c.Model} {c.HorsePower} {c.EngineSize}");
                }
            }

            using (var db = new CustomerContext())
            {
                var customers = db.Customers;
                foreach (var c in customers)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName} {c.Email} {c.Number}");
                }
            }
        }
    }
}
