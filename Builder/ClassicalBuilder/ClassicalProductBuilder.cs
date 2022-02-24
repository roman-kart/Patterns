using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Products;

namespace Builder.ClassicalBuilder
{
    public class ClassicalProductBuilder
    {
        private Product _product = new Product();
        public ClassicalProductBuilder()
        {
            _product = new Product();
        }
        public ClassicalProductBuilder SetName(string name)
        {
            this._product.Name = name;
            return this;
        }
        public ClassicalProductBuilder SetDescription(string description)
        {
            this._product.Description = description;
            return this;
        }
        public ClassicalProductBuilder SetPrice(decimal price)
        {
            this._product.Price = price;
            return this;
        }
        public Product Build()
        {
            return _product;
        }
    }
}
