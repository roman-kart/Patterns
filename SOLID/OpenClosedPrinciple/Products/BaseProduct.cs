using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosedPrinciple.Inheritance;
using OpenClosedPrinciple.Products;
using OpenClosedPrinciple.VisitorPattern;

namespace OpenClosedPrinciple.Inheritance
{
    public abstract class BaseProduct : IProductVisitorAccept
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
