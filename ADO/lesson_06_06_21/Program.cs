using System;
using System.Configuration;
using System.Data.SqlClient;

namespace lesson_06_06_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Id = 10,
                Vendor = "BMW",
                Model = "X5",
                HorsePower = 320,
                EngineSize = 4.4f
            };

            var typeOfObject = car.GetType();
            Console.WriteLine(typeOfObject.Name);
            foreach (var prop in typeOfObject.GetProperties())
            {
                Console.WriteLine($"\t{ prop.Name}");
                if (prop.Name == "Vendor")
                {
                    prop.SetValue(car, "Mersedes");
                }
            }
            Console.WriteLine($"\n\t\t{car}");
            return;

            var connectionString = ConfigurationManager.ConnectionStrings["OnlineShop"].ConnectionString;
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = connection;
            Console.WriteLine(connection.State);
            sqlCommand.CommandText = "SELECT * FROM Cars;";

            var data = sqlCommand.ExecuteReader();
            //Console.WriteLine(data.HasRows);
            //Console.WriteLine(data.FieldCount);

            while (data.Read())
            {
                Console.WriteLine($"{data["Vendor"]}  {data.GetValue(2)} {data.GetValue(3)} {data.GetValue(4)}");
            }
            //object[] o = new object[10];
            //data.GetValues(o);

            data.Close();

            connection.Close();
        }
    }
}
