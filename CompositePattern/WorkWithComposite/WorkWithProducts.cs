using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class WorkWithProducts
    {
        public static void ShowProducts(List<IProduct> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price} ({product.Description})");
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
