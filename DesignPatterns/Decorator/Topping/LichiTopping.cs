using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class LichiTopping : BaseToppings
    {
        double lichiPrice = 0.75;

        public LichiTopping(BaseAbsIceCream s)
            : base(s)
        {

        }

        public override double GetPrice()
        {
            return lichiPrice + objIceCream.GetPrice();
        }
    }
}
