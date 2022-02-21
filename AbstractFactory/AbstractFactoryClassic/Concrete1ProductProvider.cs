using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactoryClassic
{
    public class Concrete1ProductProvider : AbstractProductProvider
    {
        private readonly List<Product> _products = new List<Product>()
        {
            new Product() { Name = "Apple", Description = "Tasty apple", Id = 1, Price = 100},
            new Product() { Name = "Cereal", Price = 70, Id = 2, Description = "Good choice for wholesome breakfast"},
            new Product() { Name = "Ice cream", Description = "Cold and sweet ice cream will make your day better", Id = 3, Price = 70}
        };

        public override List<Product> GetAllProduct()
        {
            return _products.ToList();
        }

        public override Product GetProductById(int id)
        {
            return _products.First(p => p.Id == id);
        }

        public override Product GetProductByName(string name)
        {
            return _products.First(p => p.Name == name);
        }

        public override bool IsProductExist(Product product)
        {
            return _products.Contains(product);
        }
    }
}
