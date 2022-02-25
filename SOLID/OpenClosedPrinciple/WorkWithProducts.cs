using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosedPrinciple;
using OpenClosedPrinciple.Inheritance;
using OpenClosedPrinciple.Products;
using OpenClosedPrinciple.VisitorPattern;

namespace OpenClosedPrinciple
{
    public class WorkWithProducts
    {
        public static void ShowProduct(BaseProduct baseProduct)
        {
            Console.WriteLine($"{baseProduct.Name} - {baseProduct.Price} ({baseProduct.Description})");
        }
        public static void ShowProduct(ProductMongoDB productMongoDB)
        {
            Console.WriteLine($"{productMongoDB.Name} - {productMongoDB.Price} ({productMongoDB.Description}). Data = {productMongoDB.JsonData}");
        }
        public static void ShowProduct(ProductSqlServer productSqlServer)
        {
            Console.WriteLine($"{productSqlServer.Name} - {productSqlServer.Price} ({productSqlServer.Description}). " +
                $"Create date = {productSqlServer.CreateDate}, " +
                $"GUID = {productSqlServer.GUID}");
        }
    }
}
