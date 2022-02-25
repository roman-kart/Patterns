using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Good
{
    public class ShowProducts
    {
        public static void Do(Product product, string beforeInfo = "")
        {
            Console.WriteLine($"{beforeInfo}{product.Name}");
            Console.WriteLine($"{beforeInfo}{product.Price}");
            Console.WriteLine($"{beforeInfo}{product.Description}");
        }
        public static void Do(CompositProduct compositProduct, string beforeInfo = "")
        {
            Do((Product)compositProduct, beforeInfo);
            foreach (var prod in compositProduct.Products)
            {
                Do(prod, $"{beforeInfo}\t");
            }
        }
    }
}
