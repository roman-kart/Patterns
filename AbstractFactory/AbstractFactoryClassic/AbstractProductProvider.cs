using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactoryClassic
{
    public abstract class AbstractProductProvider
    {
        public abstract Product GetProductById(int id);
        public abstract Product GetProductByName(string name);
        public abstract bool IsProductExist(Product product);
        public abstract List<Product> GetAllProduct();
    }
}
