using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class ChocolateIceCream : BaseAbsIceCream
    {
        double chocPrice = 5.0;

        public override double GetPrice()
        {
            return chocPrice;
        }
    }
}
