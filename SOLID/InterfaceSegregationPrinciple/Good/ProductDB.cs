using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Good
{
    public class ProductDB
    {
        public static List<Product> Products { get; } = new List<Product>();
        public static void Add(Product product)
        {
            Products.Add(product);
        }
    }
}
