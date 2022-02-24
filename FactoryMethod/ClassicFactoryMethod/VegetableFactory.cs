using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ClassicFactoryMethod
{
    public class VegetableFactory : AbstractFactory
    {
        public override ProductAbstract GetProduct()
        {
            return new ProductVegetables() { Name = "Cucumber", Description = "dsfsdfs", Price = 85 };
        }
    }
}
