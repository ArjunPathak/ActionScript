using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class Hatchback : ICar
    {
        public int airBags
        {
            get
            {
                return 2;
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
                return 15;
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
                return 13;
            }
            set
            {
                tyreSize = value;
            }
        }

        public void Drive(int pKms)
        {
            Console.WriteLine("Drive your Hatchback " + pKms + " kms");
        }
    }
}
