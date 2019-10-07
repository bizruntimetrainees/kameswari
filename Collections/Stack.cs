using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("Kavya");
            s.Push("vyshu");
            s.Push("aparna");
            s.Push("Ratan");
            s.Push("gayi");

            foreach (string v in s)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Peek element: " + s.Peek());
            Console.WriteLine("Pop: " + s.Pop());
            Console.WriteLine("After Pop, Peek element: " + s.Peek());
            Console.ReadKey();

        }
    }
}
    
