using System;
using System.IO;
namespace TextWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("G:\\jspiders\\folder2.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling by JavaTpoint");
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}
