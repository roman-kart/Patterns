using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosedPrinciple.Inheritance;
using OpenClosedPrinciple.Products;
using OpenClosedPrinciple.VisitorPattern;

namespace OpenClosedPrinciple.VisitorPattern
{
    public interface IProductVisitor
    {
        public void Visit(BaseProduct baseProduct);
        public void Visit(ProductMongoDB productMongoDB);
    }
}
