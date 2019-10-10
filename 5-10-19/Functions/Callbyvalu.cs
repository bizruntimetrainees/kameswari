using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functioncall
{
    class Program
    {
        public void show(int val)
        {
            val *= val;
            Console.WriteLine("value inside the show notification" + val);
        }
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program();
            Console.WriteLine("before changing" +val);
            program.show(val);
            Console.WriteLine("after changing" +val);
            Console.ReadKey();

        }
    }
}
