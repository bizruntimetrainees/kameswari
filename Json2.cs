using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp32
{

    class SerializeObject
    {
        public class Product
        {
            public string name { get; set; }

            public DateTime ExpiryDate { get; set; }

            public float price { get; set; }

            public string[] Sizes { get; set; }
        }

        public static void GetDetail()
        {
            Product product = new Product();

            product.name = "Apple";
            product.ExpiryDate = new DateTime(2019, 10, 23);
            product.price = 69.35f;
            product.Sizes = new string[] { "Small", "Medium", "Large" };

            string output = JsonConvert.SerializeObject(product);


            Product DeserializedProduct = JsonConvert.DeserializeObject<Product>(output);
            Console.WriteLine("Name :: " + DeserializedProduct.name);
            Console.WriteLine("DateTime :: " + DeserializedProduct.ExpiryDate);
            Console.WriteLine("Price :: " + DeserializedProduct.price);
            Console.WriteLine("Sizes ::" +JsonConvert.SerializeObject(DeserializedProduct.Sizes));
}
        public static void Main(string[] args)
        {
            GetDetail();
            Console.ReadKey();
        }
    }
}

