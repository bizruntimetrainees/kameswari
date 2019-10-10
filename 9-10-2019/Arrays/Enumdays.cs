using System;
public class EnumExample
{
    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    public static void Main()
    {
        int x = (int)Days.Sun;
        int y = (int)Days.Mon;
        int z = (int)Days.Sat;
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Mon = {0}", y);
        Console.WriteLine("Sat = {0}", z);
        Console.ReadKey();
    }
}