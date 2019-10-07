using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        public static void Main(string[] args)
        {

            var names = new SortedSet<string>();
            names.Add("Kavya");
            names.Add("vyshu");
            names.Add("Aparna");
            names.Add("gayatri");


            foreach (var name in names)
            {
                Console.WriteLine(name);
                Console.ReadKey();
            }
        }
    }
}
