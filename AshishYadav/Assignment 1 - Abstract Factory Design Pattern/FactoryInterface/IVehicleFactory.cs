﻿using FactoryDesignPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.FactoryInterface
{
    interface IVehicleFactory
    {
        public ICarLight CreateCarLight();
        public ICarEngine CreateCarEngine();
    }


}