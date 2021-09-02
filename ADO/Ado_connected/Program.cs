using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Ado_connected
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    Console.WriteLine($"{data.GetValue(1)}  {data.GetValue(2)} {data.GetValue(3)} {data.GetValue(4)}") ;
                }
            //object[] o = new object[10];
            //data.GetValues(o);

            data.Close();

            connection.Close();
        }
    }
}
