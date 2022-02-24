using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class WorkWithProduct
    {
        public static void ShowProduct(IProduct product)
        {
            Console.WriteLine($"{product.Name} - {product.Price}. " +
                $"\nComposition: fats = {product.Fats}, proteins = {product.Proteins}, carbohydrates = {product.Carbohydrates}" +
                $"\n({product.Description})");
        }
    }
}
