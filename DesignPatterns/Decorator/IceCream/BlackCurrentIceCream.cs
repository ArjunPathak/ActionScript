using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class BlackCurrentIceCream : BaseAbsIceCream
    {
        double bcPrice = 4.25;

        public override double GetPrice()
        {
            return bcPrice;
        }
    }
}
