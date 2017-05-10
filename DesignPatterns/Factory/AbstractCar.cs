using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    abstract class AbstractCar
    {
        public abstract ICar GetCar(string type);
    }
}
