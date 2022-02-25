using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class BadProduct
    {
        public static List<BadProduct> badProducts = new List<BadProduct>();
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public void AddProduct()
        {
            badProducts.Add(this);
        }
        public void RemoveProduct()
        {
            badProducts.Remove(this);
        }
        public bool IsProductInDatabase()
        {
            return badProducts.Contains(this);
        }
    }
}
