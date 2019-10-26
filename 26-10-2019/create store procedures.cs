using System;
using System.Data.SqlClient;
 
namespace Create_Store_Procedure
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=106.51.126.111;" + "Initial Catalog=kameswari;" + "User id=sa;" +
 "Password=bizruntime@123;";
            SqlConnection con = new SqlConnection(ConString);
            string query =
              @"
                select SPECIFIC_NAME from kameswari.information_schema.routines where routine_type = 'PROCEDURE'
            ";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["SPECIFIC_NAME"].ToString());
                }
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