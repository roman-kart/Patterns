using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosedPrinciple.Inheritance;
using OpenClosedPrinciple.Products;
using OpenClosedPrinciple.VisitorPattern;


namespace OpenClosedPrinciple.Products
{
    public class ProductMongoDB : BaseProduct, IProductVisitorAccept
    {
        public string JsonData { get; set; }

        public void Accept(IProductVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
