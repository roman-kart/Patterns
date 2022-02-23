using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactoryClassic
{
    public class NeedProducts
    {
        public void ShowAllProduct(AbstractProductProvider provider)
        {
            var prods = provider.GetAllProduct();
            foreach (var product in prods)
            {
                Console.WriteLine($"{product.Id}: {product.Name}, {product.Price} ({product.Description})");
            }
        }
    }
}
