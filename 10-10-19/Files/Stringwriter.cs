using System;
using System.IO;
using System.Text;
namespace CSharpProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = "Hello, Welcome to the javatpoint ";


            StringBuilder sb = new StringBuilder();  
            StringWriter writer = new StringWriter(sb);
            writer.WriteLine(text);
            writer.Flush();
            writer.Close();
            StringReader reader = new StringReader(sb.ToString());
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
                Console.ReadKey();
            }
        }



    }
} 