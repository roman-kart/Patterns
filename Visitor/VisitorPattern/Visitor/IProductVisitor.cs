using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Products;

namespace VisitorPattern.Visitor
{
    internal interface IProductVisitor
    {
        void Visit(Milk milk);
        void Visit(Cereal cereal);
    }
}
