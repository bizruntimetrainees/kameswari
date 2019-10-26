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
                CREATE PROCEDURE Insert_Record_Procedure
                (
                @Name VARCHAR(50),
                @Price VARCHAR(50),
                @Date DATETIME
                )
              AS
                INSERT INTO Products(Name,Price,Date) Values(@Name,@Price,@Date)
            ";

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Store Procedure Created Successfully");
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