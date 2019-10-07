using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new LinkedList<String>();
            v.AddLast("kavya");
            v.AddFirst("Aparna");
            v.AddLast("Vyshu");
            v.AddLast("gayatri");


            foreach (var k in v)
            {
                Console.WriteLine(k);
                Console.ReadKey();
            }
        }
    }
}
    
