using System;
using System.IO;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream f = new FileStream("G:\\jspiders\\folder1", FileMode.OpenOrCreate);

           for(int i=65;i<=90;i++)
            {
                f.WriteByte((byte)i);
            }   
            f.Close();
        }
    }
}
