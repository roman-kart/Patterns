﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Products
{
    public abstract class ProductAbstract
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract decimal Price { get; set; }
    }
}
