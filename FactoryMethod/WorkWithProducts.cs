using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.ClassicFactoryMethod;
using FactoryMethod.Products;

namespace FactoryMethod
{
    public class WorkWithProductClassical
    {
        private AbstractFactory _abstractFactory;
        public WorkWithProductClassical(AbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
        }
        public void AboutProduct()
        {
            var product = _abstractFactory.GetProduct();
            Console.WriteLine($"{product.Name} - {product.Price} ({product.Description})");
        }
    }
    public class WorkWithProductStatic
    {
        private StaticFactoryMethod.StaticFactoryMethod _staticFactory;
        public WorkWithProductStatic(StaticFactoryMethod.StaticFactoryMethod factoryMethod)
        {
            _staticFactory = factoryMethod;
        }
        public void AboutFruit()
        {
            var product = _staticFactory.GetProduct(StaticFactoryMethod.ProductKinds.Fruit);
            Console.WriteLine($"{product.Name} - {product.Price} ({product.Description})");
        }
        public void AboutVegetable()
        {
            var product = _staticFactory.GetProduct(StaticFactoryMethod.ProductKinds.Vegetables);
            Console.WriteLine($"{product.Name} - {product.Price} ({product.Description})");
        }
    }
}
