using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class BaseToppings : BaseAbsIceCream
    {
        protected BaseAbsIceCream objIceCream { get; set; }

        protected BaseToppings(BaseAbsIceCream s)
        {
            objIceCream = s;
        }
    }
}
