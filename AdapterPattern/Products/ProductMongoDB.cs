using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Products
{
    public class ProductMongoDB
    {
        public About about { get; set; }
        public Composition composition { get; set; }
        public ProductMongoDB(About about, Composition composition)
        {
            this.about = about;
            this.composition = composition;
        }
        public class About
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
        public class Composition
        {
            public byte Carbohydrates { get; set; }
            public byte Fats { get; set; }
            public byte Proteins { get; set; }
        }
    }
}
