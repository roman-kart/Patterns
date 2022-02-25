using OpenClosedPrinciple.Inheritance;
using OpenClosedPrinciple.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.VisitorPattern
{
    public class ShowProductVisitor : IProductVisitor
    {
        public void Visit(BaseProduct baseProduct)
        {
            Console.WriteLine($"{baseProduct.Name} - {baseProduct.Price} ({baseProduct.Description})");
        }

        public void Visit(ProductMongoDB productMongoDB)
        {
            Console.WriteLine($"{productMongoDB.Name} - {productMongoDB.Price} ({productMongoDB.Description}). Data = {productMongoDB.JsonData}");
        }
    }
}
