using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public interface IGoodProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class GoodProduct : IGoodProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class WorkWithGoodProduct
    {
        public static List<IGoodProduct> goodProducts { get; set; } = new List<IGoodProduct>();
        public static void AddProduct(IGoodProduct goodProduct)
        {
            goodProducts.Add(goodProduct);
        }
        public static void RemoveProduct(IGoodProduct goodProduct)
        {
            goodProducts.Remove(goodProduct);
        }
        public static bool IsProductInDatabase(IGoodProduct goodProduct)
        {
            return goodProducts.Contains(goodProduct);
        }
    }
}
