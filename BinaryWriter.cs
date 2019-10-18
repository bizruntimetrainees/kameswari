using System;
using System.IO;
namespace BinaryWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "G:\\kavya2\\binaryfile.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}