using Mediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.View
{
    public class ProductsShow : IShowProducts
    {
        public void ShowProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, " +
                    $"Name: {product.Name}, " +
                    $"Price: {product.Price}, " +
                    $"CreatedDate: {product.CreatedDate}");
            }
        }
    }
}
