using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Products;

namespace FactoryMethod.StaticFactoryMethod
{
    public class StaticFactoryMethod
    {
        public ProductAbstract GetProduct(ProductKinds productKind)
        {
            switch (productKind)
            {
                case ProductKinds.Vegetables:
                    return new ProductVegetables() { Name = "Carrot", Price = 40, Description = "fsdfsdfsfg" };
                    break;
                case ProductKinds.Fruit:
                    return new ProductFruit() { Name = "Melon", Price = 80, Description = "Sdfsdfsdf" };
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Нет такого типа продукта");
                    break;
            }
        }
    }
}
