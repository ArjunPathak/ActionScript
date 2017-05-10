using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class FudgeTopping : BaseToppings
    {
        double fudgePrice = 0.25;

        public FudgeTopping(BaseAbsIceCream s)
            : base(s)
        {

        }

        public override double GetPrice()
        {
            return fudgePrice + objIceCream.GetPrice();
        }
    }
}
