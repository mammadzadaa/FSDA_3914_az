using System;

namespace Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            using CarsContext db = new CarsContext();
            var cars = db.Cars;

            foreach (var c in cars)
            {
                Console.WriteLine($"{c.Vendor} {c.Model} {c.HorsePower} {c.EngineSize}");
            }

            Console.ReadKey();
            var kia = new Car()
            {
                Vendor = "Kia",
                Model = "Serato",
                EngineSize = 2.2f,
                HorsePower = 173
            };

            var mazda = new Car()
            {
                Vendor = "Mazda",
                Model = "6",
                EngineSize = 2.5f,
                HorsePower = 190
            };

            db.Cars.Add(kia);
            db.Cars.Add(mazda);
            db.SaveChanges();
        }
    }
}
