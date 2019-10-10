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
            Dictionary<string, string> v = new Dictionary<string, string>();
            v.Add("1", "Sonoo");
            v.Add("2", "Peter");
            v.Add("3", "James");
            v.Add("4", "Ratan");
            v.Add("5", "Irfan");

            foreach (KeyValuePair<string, string> kv in v)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
                Console.ReadKey();
            }
        }
    }
}
   
