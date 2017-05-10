using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public interface ICar
    {
        int airBags { get; set; }
        int zeroTo100 { get; set; }
        int tyreSize { get; set; }

        void Drive(int kms);
    }
}
