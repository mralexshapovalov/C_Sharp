using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Relationships.Aggregation
{
    public abstract class Engine
    { }
    public class Car
    {
        Engine engine;
        public Car(Engine eng)
        {
            engine = eng;
        }
    }

}
