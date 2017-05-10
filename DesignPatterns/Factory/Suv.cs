using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class Suv : ICar
    {
        public int airBags
        {
            get
            {
                return 6;
            }
            set
            {
                airBags = value;
            }
        }

        public int zeroTo100
        {
            get
            {
                return 7;
            }
            set
            {
                zeroTo100 = value;
            }
        }

        public int tyreSize
        {
            get
            {
                return 16;
            }
            set
            {
                tyreSize = value;
            }
        }

        public void Drive(int pKms)
        {
            Console.WriteLine("Drive your SUV " + pKms + " kms");
        }
    }
}
