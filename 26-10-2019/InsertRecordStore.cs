using System;
using System.Data.SqlClient;
using System.Data;
 
namespace Create_Store_Procedure
{
    class Program
    {
        static void Main(string[] args)
        {

            string ConString = @"Data Source=106.51.126.111;" + "Initial Catalog=kameswari;" + "User id=sa;" +
 "Password=bizruntime@123;";
            SqlConnection con = new SqlConnection(ConString);
            SqlCommand cmd = new SqlCommand("Insert_Record_Procedure", con);
            try
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Name", "SSD DRIVE"));
                cmd.Parameters.Add(new SqlParameter("@Price", "$300"));
                cmd.Parameters.Add(new SqlParameter("@Date", "25 August 14"));
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Records Inserted Successfully.");
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