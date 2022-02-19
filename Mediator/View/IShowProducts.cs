using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Model;

namespace Mediator
{
    public interface IShowProducts
    {
        /// <summary>
        /// Объект, реализующий этот интерфейс, будет использоваться в Посреднике
        /// </summary>
        /// <returns></returns>
        public void ShowProducts(List<Product> products);
    }
}
