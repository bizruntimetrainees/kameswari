using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        public string show(string message)
        {
            Console.WriteLine("Hello");
            return message;
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.show("kameswari");
            
            Console.ReadKey();
        }
    }
}
