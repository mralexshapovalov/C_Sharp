﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Relationships.Composition
{
    class Car
    {
        ElectricEngine engine;
        public Car()
        {
            engine = new ElectricEngine();
        }
    }
}
