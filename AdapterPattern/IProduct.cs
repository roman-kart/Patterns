using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte Proteins { get; set; }
        public byte Carbohydrates { get; set; }
        public byte Fats { get; set; }
        public decimal Calories { get; }
    }
}
