﻿using FactoryDesignPattern.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Products
{
    class Revtron : ICarEngine
    {
        public void Start(ICarLight h)
        {
            Console.WriteLine(GetType().Name + " pairs with " + h.GetType().Name);
        }
    }
}
