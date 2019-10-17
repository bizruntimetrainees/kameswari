using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronousprogram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Method();
            NewMethod();
            Console.WriteLine("Method");
           
            Console.ReadKey();
        }
            public static async void Method()
            {
                await Task.Delay(1000);
               Console.WriteLine("Method1");
            }
        public static async void NewMethod()
        {
            await Task.Delay(1000);
            Console.WriteLine("Method2");
        }

    }
}

