using System;
using System.IO;
namespace CSharpProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              
                string loc = "G:\\kavya2\\folder3.txt";
                 FileInfo file = new FileInfo(loc);
                   file.Create();
                Console.WriteLine("File is created Successfuly");




            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }
    }
}