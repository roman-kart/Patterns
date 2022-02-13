using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Controller;
using Mediator.Model;
using Mediator.View;

namespace Mediator
{
    /// <summary>
    /// Посредник, который реализует взаимодействие между двумя несвязными классами
    /// </summary>
    public class ProductMediator
    {
        public void GetThanShowProducts()
        {
            IGetProducts getter = new ProductsOperations();
            IShowProducts demonstrator = new ProductsShow();

            var products = getter.GetProducts();
            demonstrator.ShowProducts(products);
        }
    }
}
