using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Bad
{
    public class BadProductChildren : ParentProduct
    {
        public override decimal GetCurrentPrice()
        {
            return base.Price;
        }
        public override decimal GetDiscountMoney()
        {
            return base.DiscountPercent;
        }
    }
}
