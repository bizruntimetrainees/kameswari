using System;
using System.IO;
namespace TextReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("G:\\jspiders\\folder2.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
        }
    }
}