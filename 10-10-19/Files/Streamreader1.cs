using System;
using System.IO;
public class StreamReaderExample
{
    public static void Main(string[] args)
    {
        FileStream f = new FileStream("G:\\jspiders\\ffolder1.txt", FileMode.OpenOrCreate);
        StreamReader s = new StreamReader(f);

        string line = s.ReadLine();
        Console.WriteLine(line);
        Console.ReadKey();
        s.Close();
        f.Close();
    }
}