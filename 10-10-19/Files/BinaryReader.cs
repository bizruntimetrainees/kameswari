using System;
using System.IO;
namespace BinaryWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("G:\\kavya2\\binaryfile.dat", FileMode.Create)))
            {

                writer.Write(12.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("G:\\binaryfile.dat", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
    }
}