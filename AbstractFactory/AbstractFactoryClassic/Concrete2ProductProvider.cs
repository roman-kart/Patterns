using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactoryClassic
{
    public class Concrete2ProductProvider : AbstractProductProvider
    {
        private readonly List<Product> _products = new List<Product>()
        {
            new Product() { Name = "Milk", Description = "Mmm, my milk", Id = 1, Price = 80},
            new Product() { Name = "Melon", Price = 30, Id = 2, Description = "Very nice"},
            new Product() { Name = "Pasta", Description = "Description :)", Id = 3, Price = 150}
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
