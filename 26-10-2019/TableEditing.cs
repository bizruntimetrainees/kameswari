using System;
using System.Data.SqlClient;
 
namespace CreateColumn
{
    class Program
    {
        static void Main(string[] args)
        {
             string ConString = @"Data Source=106.51.126.111;" + "Initial Catalog=kameswari;" + "User id=sa;" +
 "Password=bizruntime@123;";
            SqlConnection con = new SqlConnection(ConString);
            string query =
                @"ALTER TABLE Accessories
                  ALTER COLUMN Stock int;";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Column Edited Successfully");
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