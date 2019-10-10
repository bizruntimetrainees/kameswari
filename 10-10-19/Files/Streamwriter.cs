using System;
using System.IO;
public class StreamWriterExample
{
    public static void Main(string[] args)
    {
        FileStream f = new FileStream("G://jspiders//ffolder1.txt", FileMode.Create);
        StreamWriter s = new StreamWriter(f);

        s.WriteLine("hello c#");
        s.Close();
        f.Close();
        Console.WriteLine("File created successfully...");
    }
}