﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Relationships.Realization
{
    class Car :IMovable
    {
        public void Move()
        {
            Console.WriteLine("Машина едет");
        }
    }
}
