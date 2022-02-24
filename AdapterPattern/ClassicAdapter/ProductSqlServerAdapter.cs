using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Products;


namespace AdapterPattern.ClassicAdapter
{
    public class ProductSqlServerAdapter : IProduct
    {
        private readonly ProductSqlServer _productSqlServer;
        public ProductSqlServerAdapter(ProductSqlServer productSqlServer)
        {
            _productSqlServer = productSqlServer;
        }

        public string Name
        {
            get
            {
                return _productSqlServer.Name;
            }
            set
            {
                _productSqlServer.Name = value;
            }
        }
        public string Description
        {
            get
            {
                return _productSqlServer.Description;
            }
            set
            {
                _productSqlServer.Description = value;
            }
        }
        public decimal Price
        {
            get
            {
                return _productSqlServer.Price;
            }
            set
            {
                _productSqlServer.Price = value;
            }
        }
        public byte Proteins
        {
            get
            {
                return _productSqlServer.Proteins;
            }
            set
            {
                _productSqlServer.Proteins = value;
            }
        }
        public byte Carbohydrates
        {
            get
            {
                return _productSqlServer.Carbohydrates;
            }
            set
            {
                _productSqlServer.Carbohydrates = value;
            }
        }
        public byte Fats
        {
            get
            {
                return _productSqlServer.Fats;
            }
            set
            {
                _productSqlServer.Fats = value;
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
