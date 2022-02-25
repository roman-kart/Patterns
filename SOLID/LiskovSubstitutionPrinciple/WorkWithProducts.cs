using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitutionPrinciple;

namespace LiskovSubstitutionPrinciple
{
    public class WorkWithProducts
    {
        public static void ShowPorduct(ParentProduct parentProduct)
        {
            Console.WriteLine();
            Console.WriteLine($"About {parentProduct.Name}: ");
            Console.WriteLine($"Price = {parentProduct.GetCurrentPrice()}");
            Console.WriteLine($"Discount = {parentProduct.GetDiscountMoney()}");
            Console.WriteLine();
        }
    }
}
