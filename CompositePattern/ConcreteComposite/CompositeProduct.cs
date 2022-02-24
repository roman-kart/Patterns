using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.ConcreteComposite
{
    public class CompositeProduct : ICompositeProduct
    {
        public List<IProduct> Composition { get; set; } = new List<IProduct>();
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public void Add(IProduct product)
        {
            Composition.Add(product);
        }

        public void Remove(IProduct product)
        {
            Composition.Remove(product);
        }
    }
}
