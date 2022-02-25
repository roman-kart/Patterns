using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Bad
{
    public class WorkWithProducts
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        public static void ShowProduct(Product product)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Description);
        }
        public static void ShowComposiitonProduct(CompositProduct product)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.Description);
            foreach (var prod in product.Products)
            {
                Console.WriteLine($"\t{prod.Name}");
                Console.WriteLine($"\t{prod.Price}");
                Console.WriteLine($"\t{prod.Description}");
            }
        }
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
