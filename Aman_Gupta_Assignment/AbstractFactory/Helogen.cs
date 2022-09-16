﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Helogen : CarEngine
    {
        public override string DisplayEngine()
        {
            return String.Format(this.GetType().Name + " engine");
        }
    }
}
