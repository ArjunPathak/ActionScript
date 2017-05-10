using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class SprinkleTopping : BaseToppings
    {
        double sprnklePrice = 1.25;

        public SprinkleTopping(BaseAbsIceCream s)
            : base(s)
        {

        }

        public override double GetPrice()
        {
            return sprnklePrice + objIceCream.GetPrice();
        }
    }
}
