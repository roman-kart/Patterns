using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Products
{
    public class ProductSqlServer
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte Carbohydrates { get; set; }
        public byte Fats { get; set; }
        public byte Proteins { get; set; }
        public ProductSqlServer(string name, string description, decimal price, byte carbohydrates, byte fats, byte proteins)
        {
            Name = name; ;
            Description = description;
            Price = price;
            Carbohydrates = carbohydrates;
            Fats = fats;
            Proteins = proteins;
        }
    }
}
