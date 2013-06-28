using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeProject
{
    class EuroCoffee:Coffee
    {
        public EuroCoffee() {
            this.UnitPrice = 3;
        }
        //public EuroCoffee(string coffeeType, double unitPrice) : base(coffeeType, unitPrice) { }

        public override void displayInfo()
        {
            Console.WriteLine("You order an Euro coffee!");
        }

        public override void displayPrice()
        {
            Console.WriteLine("The original price is {0}$",this.UnitPrice);
        }
    }
}
