using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainThread
{
    class Program
    {
        static void Main(string[] args)
        {
                Thread t = Thread.CurrentThread;
                t.Name = "MainThread";
                Console.WriteLine(t.Name);
            Console.ReadKey();
            }
        }
    }
    

