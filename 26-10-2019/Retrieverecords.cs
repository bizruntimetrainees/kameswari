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
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Retrieve_Record_Proc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Name", "HardDisk"));
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Product Name : " + dr[1].ToString());
                    Console.WriteLine("Price : " + dr[2].ToString());
                    Console.WriteLine("Date : " + dr[3].ToString());
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
