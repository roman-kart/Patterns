using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Products;

namespace AdapterPattern.ClassicAdapter
{
    public class ProductMongoDBAdapter : IProduct
    {
        private readonly ProductMongoDB _productMongoDB;
        public ProductMongoDBAdapter(ProductMongoDB productMongoDB)
        {
            _productMongoDB = productMongoDB;
        }
        public string Name
        {
            get
            {
                return _productMongoDB.about.Name;
            }
            set
            {
                _productMongoDB.about.Name = value;
            }
        }
        public string Description
        {
            get
            {
                return _productMongoDB.about.Description;
            }
            set
            {
                _productMongoDB.about.Description = value;
            }
        }
        public decimal Price
        {
            get
            {
                return _productMongoDB.about.Price;
            }
            set
            {
                _productMongoDB.about.Price = value;
            }
        }
        public byte Proteins
        {
            get
            {
                return _productMongoDB.composition.Proteins;
            }
            set
            {
                _productMongoDB.composition.Proteins = value;
            }
        }
        public byte Carbohydrates
        {
            get
            {
                return _productMongoDB.composition.Carbohydrates;
            }
            set
            {
                _productMongoDB.composition.Carbohydrates = value;
            }
        }
        public byte Fats
        {
            get
            {
                return _productMongoDB.composition.Fats;
            }
            set
            {
                _productMongoDB.composition.Fats = value;
            }
        }
        public decimal Calories
        {
            get
            {
                return 4 * (Proteins + Carbohydrates) + 9 * Fats;
            }
        }
    }
}
