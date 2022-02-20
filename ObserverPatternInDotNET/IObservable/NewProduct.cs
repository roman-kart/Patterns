using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternInDotNET.IObservable
{
    public class NewProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public NewProduct(string name, string description, decimal price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
