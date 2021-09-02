using System;
using System.Data.SqlClient;

namespace Ado_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            using SqlConnection connection = new SqlConnection();
 
            connection.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Integrated Security=True";
            connection.Open();
            Console.WriteLine(connection.State);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            string tableName = Console.ReadLine();
            //command.CommandText = "USE Afti;\n" +
            //                        $"CREATE TABLE {tableName}" +
            //                        "(Id INT)";


            command.CommandText = "USE Afti;\n" +
                                    $"DROP TABLE {tableName}";
            Console.ReadKey(true);


            int res = command.ExecuteNonQuery();
            Console.WriteLine(res);

            connection.Close();
        }
    }
}
