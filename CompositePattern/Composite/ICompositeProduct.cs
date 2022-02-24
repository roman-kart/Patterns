using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface ICompositeProduct : IProduct
    {
        public List<IProduct> Composition { get; set; }
        public void Add(IProduct product);
        public void Remove(IProduct product);
    }
}
