using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{

    class SerializeObject
    {
        public class Product
        {


            public DateTime ExpiryDate { get; set; }
        }

        public static void GetDetail()
        {
            Product product = new Product();
            product.ExpiryDate = new DateTime(2008, 12, 28);

            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter("G:\\ram.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);


                Console.WriteLine("complete");
            }
        }
        public static void Main(string[] args)
        {
            GetDetail();
            Console.ReadKey();
        }
    }
}
