using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class VanillaIceCream : BaseAbsIceCream
    {
        double vanillaPrice = 2.25;

        public override double GetPrice()
        {
            return vanillaPrice;
        }
    }
}
