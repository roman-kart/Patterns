using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitor;

namespace VisitorPattern.Products
{
    internal class Cereal : Product
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override decimal Price { get; set; }

        public override void Accept(IProductVisitor productVisitor)
        {
            productVisitor.Visit(this);
        }
    }
}

