using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Products;

namespace Builder.ConditionBuilder
{
    public class ConditionBuilder
    {
        private Product _product;
        public ConditionBuilder()
        {
            _product = new Product();
        }
        public ConditionBuilder AddDescription(string description)
        {
            _product.Description = description;
            return this;
        }
        public ConditionBuilderNameAdded AddName(string name)
        {
            _product.Name = name;
            return new ConditionBuilderNameAdded(_product);    
        }
    }

    public class ConditionBuilderNameAdded
    {
        private Product _product;
        internal ConditionBuilderNameAdded(Product product)
        {
            _product = product;
        }
        public ConditionBuilderPriceAdded AddPrice(decimal price)
        {
            _product.Price = price;
            return new ConditionBuilderPriceAdded(_product);
        }
    }
    public class ConditionBuilderPriceAdded
    {
        private Product _product;
        internal ConditionBuilderPriceAdded(Product product)
        {
            _product = product;
        }
        public Product Build()
        {
            return _product;
        }
    }
}
