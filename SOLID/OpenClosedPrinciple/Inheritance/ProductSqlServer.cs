using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Inheritance
{
    public class ProductSqlServer : BaseProduct
    {
        public Guid GUID { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
