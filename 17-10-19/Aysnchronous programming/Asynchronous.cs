using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Class1
    {
        public static void Main(String[] args)
        {
            Method();
            Console.WriteLine("Method");
            Console.ReadKey();

        }
        public static async void Method()
        {
            await Task.Run(new Action(LongAction));
            Console.WriteLine("Method1");
        }
        public static void LongAction()
        {
            Thread.Sleep(20000);
        }

    }


}
