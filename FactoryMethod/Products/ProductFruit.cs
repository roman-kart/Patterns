using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public class ProductFruit : ProductAbstract
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override decimal Price { get; set; }
    }
}
