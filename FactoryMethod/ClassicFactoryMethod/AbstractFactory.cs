using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Products;

namespace FactoryMethod.ClassicFactoryMethod
{
    public abstract class AbstractFactory
    {
        public abstract ProductAbstract GetProduct();
    }
}
