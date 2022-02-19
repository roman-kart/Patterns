using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Model;

namespace Mediator
{
    public interface IGetProducts
    {
        /// <summary>
        /// Объект, реализующий этот интерфейс, будет использоваться в Посреднике
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts();
    }
}
