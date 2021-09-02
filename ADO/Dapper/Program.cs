using System;
using System.Data.Common;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace DapperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = "data source=localhost\\SQLEXPRESS;initial catalog=OnlineShop;integrated security=True;MultipleActiveResultSets=True";
            connection.Open();

            var sqlcommand = "SELECT * FROM Cars";
            var cars = connection.Query<Car,Owner,Car>(sqlcommand,(car,owner)=> {
                car.Owner = owner;
                return car;
            });
            cars.ToList().ForEach(x => Console.WriteLine($"{x.Vendor} {x.Model}"));
        }
    }
}
