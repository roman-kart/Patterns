using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class CompositProduct : Product
    {
        public List<Product> Products { get; set; }
    }
}
