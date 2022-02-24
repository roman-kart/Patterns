using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class WorkWithCompositeProducts
    {
        public static void ShowProducts(List<ICompositeProduct> compositeProducts)
        {
            foreach (var compositeProduct in compositeProducts)
            {
                Console.WriteLine($"{compositeProduct.Name} - {compositeProduct.Price} ({compositeProduct.Description})");
                Console.WriteLine("Composition: ");
                foreach (var product in compositeProduct.Composition)
                {
                    Console.WriteLine($"\t{product.Name} ({product.Description})");
                }
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
