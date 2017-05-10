using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class CarFactory : AbstractCar
    {
        public override ICar GetCar(string type)
        {
            ICar requiredCar = new Sedan();
            switch (type)
            {
                case "sports":
                    requiredCar = new Sedan();
                    break;

                case "sedan":
                    requiredCar = new Sedan();
                    break;

                case "hatchback":
                    requiredCar = new Hatchback();
                    break;

                case "suv":
                    requiredCar = new Suv();
                    break;
            }

            return requiredCar;
            
        }
    }
}
