using System;
using System.Data.SqlClient;
 
namespace RenameDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection( @"Data Source=106.51.126.111;" + "Initial Catalog=kameswari;" + "User id=sa;" +
 "Password=bizruntime@123;");
            string query = "ALTER DATABASE Customers MODIFY NAME = MobileShop";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Renamed Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}