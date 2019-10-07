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
            Queue<string> s = new Queue<string>();
            s.Enqueue("Kavya");
            s.Enqueue("vyshu");
            s.Enqueue("aparna");
            s.Enqueue("Ratan");
            s.Enqueue("gayi");

            foreach (string v in s)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Peek element: " + s.Peek());
            Console.WriteLine("Pop: " + s.Dequeue());
            Console.WriteLine("After Pop, Peek element: " + s.Peek());
            Console.ReadKey();

        }
    }
}

