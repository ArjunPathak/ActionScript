using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class StrawberryIceCream : BaseAbsIceCream
    {
        double sbryPrice = 3.50;

        public override double GetPrice()
        {
            return sbryPrice;
        }
    }
}
