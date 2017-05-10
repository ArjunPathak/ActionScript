using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Decorator;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseAbsIceCream myIceCream = new BlackCurrentIceCream();
            myIceCream = new LichiTopping(myIceCream);
            myIceCream = new FudgeTopping(myIceCream);

            Console.WriteLine("Your bill : " + myIceCream.GetPrice());

            Console.ReadKey();

        }
    }
}
