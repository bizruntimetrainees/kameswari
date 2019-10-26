using System;
using System.Data.SqlClient;
using System.Data;

namespace DataSet_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConString = @"Data Source=106.51.126.111;" + "Initial Catalog=kameswari;" + "User id=sa;" +
 "Password=bizruntime@123;";
            string querystring = "Select * from Customers";
            SqlDataAdapter adapter = new SqlDataAdapter(querystring, ConString);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Customers");
            Console.WriteLine(ds.GetXml());
            Console.ReadKey();
        }
    }
}