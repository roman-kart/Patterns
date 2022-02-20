using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitor;

namespace VisitorPattern.Products
{
    internal abstract class Product
    {
        public abstract void Accept(IProductVisitor productVisitor);
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract decimal Price { get; set; }
    }
}
