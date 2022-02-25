using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class ParentProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercent { get; set; }
        public virtual decimal GetCurrentPrice()
        {
            return Price - (Price * (DiscountPercent / 100));
        }
        public virtual decimal GetDiscountMoney()
        {
            return Price * (DiscountPercent / 100);
        }
    }
}
