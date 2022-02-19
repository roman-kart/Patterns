using Mediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Controller
{
    public class ProductsOperations : IGetProducts
    {
        public List<Product> GetProducts()
        {
            // возвращаем фиктивные данные
            return new List<Product> { new Product { Id = 1, Name = "Test1", CreatedDate = DateTime.Now, Price = 123m } };
        }
    }
}
