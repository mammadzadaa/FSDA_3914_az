using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Lesson_09_07_21
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["OnlineShop"].ConnectionString;
            using SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var dataSet = new DataSet();
            var itemsAdapter = new SqlDataAdapter();

            

            itemsAdapter.SelectCommand = new SqlCommand("SELECT * FROM Cars", connection);
            itemsAdapter.Fill(dataSet, "Cars");

            itemsAdapter.UpdateCommand = new SqlCommand("",connection);

            dataSet.Tables["Cars"].Rows.Add();

            itemsAdapter.Update(dataSet, "Cars");

           

        }
    }
}
