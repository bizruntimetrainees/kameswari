using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write("After swap a= " + a + " b= " + b);
            Console.ReadKey();
        }
    }
}