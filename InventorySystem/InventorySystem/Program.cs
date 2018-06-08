using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
             int i;

            

            List<ProductDetails> product = new List<ProductDetails>();
            
            product.Add(new ProductDetails("lettuce", 10.5, 50, "Leafy green"));
            product.Add(new ProductDetails("cabbage", 20, 100, "Cruciferous"));
            product.Add(new ProductDetails("pumpkin", 30, 30, "Marrow"));
            product.Add(new ProductDetails("cauliflower", 10, 25, "Cruciferous"));
            product.Add(new ProductDetails("zucchini", 20.5, 50, "Marrow"));
            product.Add(new ProductDetails("yam", 30, 50, "Root"));
            product.Add(new ProductDetails("spnach", 10, 100, "Leafy green"));
            product.Add(new ProductDetails("broccoli", 20.2, 75, "Cruciferous"));
            product.Add(new ProductDetails("Garlic", 30, 20, "Leafy green"));
            product.Add(new ProductDetails("silverbeet", 10, 50, "Marrow"));

            //for(i=0;i<10;i++)
            //{
            //    //product[i].name = "lettuce";
            //    //product[i].price = 10.5;
            //    //product[i].quantity = 50;
            //    //product[i].type = "Leafy green";
            //    product[i].Add(new ProductDetails ( Name="lettuce", Price=10.5, Quantity=50, Type="Leafy green" ));
            //}





            foreach (var p in product)
            {
                Console.WriteLine(p);
            }


            Console.WriteLine("\n total no of product:" + product.Count);

            Console.WriteLine("\nafter adding new product:");
            product.Add(new ProductDetails("silverbeet", 10, 50, "Marrow"));
            foreach (var p in product)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\n total no of product :" + product.Count);

            Console.WriteLine("\n products having type leafy green");
            foreach (var p in product)
            {
                if (p.Type == "Leafy green")
                    Console.WriteLine(p);
            }

            Console.WriteLine("\n After all garlic are sold out.");

            product.RemoveAll(x => x.Name == "Garlic");
            foreach (var p in product)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n total no of product:" + product.Count);

            

            foreach (var p in product)
            {
                if (p.Name == "cabbage")
                    p.Quantity = p.Quantity + 50;
            }

            int k = product.FindIndex(x => x.Name == "cabbage");
            Console.WriteLine("\nafter adding 50 cabbages quantity is:"+product[k].Quantity);


            double rs = 0;
            foreach(var p in product)
            {
                if (p.Name == "lettuce")
                    rs = rs + 10.5;
                else if (p.Name == "zucchini")
                    rs = rs + (2 * 20.5);
                else if (p.Name == "broccoli")
                    rs = rs + 20.2;
            }

            Console.WriteLine("\n total amount is :" + rs);
        }
    }
}
