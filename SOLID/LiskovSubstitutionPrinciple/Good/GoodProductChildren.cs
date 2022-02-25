using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Good
{
    public class GoodProductChildren : ParentProduct
    {
        public decimal FixedDiscount { get; set; }
        public override decimal GetCurrentPrice()
        {
            return base.GetCurrentPrice() - FixedDiscount;
        }
        public override decimal GetDiscountMoney()
        {
            return base.GetDiscountMoney() + FixedDiscount;
        }
    }
}
