using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverriding.cs
{
    class Program
    {
        public void property()
        {
            Console.WriteLine("cash+Land+Gold");
        }
        public void marry()
        {
            Console.WriteLine("subhalakshmi");

        }
        class c : Program
        {
            public void marry()
            {
                Console.WriteLine("Lavanya");
                Console.ReadKey();



            }

        }
        public class Testoverloading
        {
            public static void Main()
            {
                c m = new c();
                m.marry();
               

            }
        }
    }
}
    
