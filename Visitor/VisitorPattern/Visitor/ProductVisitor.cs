using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Products;

namespace VisitorPattern.Visitor
{
    internal class ProductVisitor : IProductVisitor
    {
        public void DoSomething(Product product)
        {
            product.Accept(this);
        }
        public void Visit(Milk milk)
        {
            Console.WriteLine($"We visited milk!" +
                $"\nMilk's parametres: {milk.Name}, {milk.Price} ({milk.Description})");
        }

        public void Visit(Cereal cereal)
        {
            Console.WriteLine($"We visited cereal!" +
                $"\nCereal's parametres: {cereal.Name}, {cereal.Price} ({cereal.Description})");
        }
    }
}
