using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset
{
    class Program
    {
        static void Main(string[] args)
            {

                var names = new HashSet<String>();
                names.Add("Kavya");
                names.Add("Ankit");
                names.Add("gayatri");
                names.Add("vyshu");


                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
    
