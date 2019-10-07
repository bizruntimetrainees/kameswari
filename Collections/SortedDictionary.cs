using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> v = new SortedDictionary<string, string>();
            v.Add("5", "Sonoo");
            v.Add("2", "Peter");
            v.Add("1", "James");
            v.Add("3", "Ratan");
            v.Add("4", "Irfan");

            foreach (KeyValuePair<string, string> kv in v)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
                Console.ReadKey();
            }
        }
    }
}

