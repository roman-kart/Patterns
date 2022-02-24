using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ClassicFactoryMethod
{
    public class FruitFactory : AbstractFactory
    {
        public override ProductAbstract GetProduct()
        {
            return new ProductFruit() { Name = "Orange", Description = "sd;lkfds;f", Price = 100 };
        }
    }
}
