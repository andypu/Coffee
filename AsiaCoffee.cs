using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeProject
{
    class AsiaCoffee:Coffee
    {
        public AsiaCoffee() {
            this.UnitPrice = 5;
        }
        //public AsiaCoffee(string coffeeType, double unitPrice) : base(coffeeType, unitPrice) { }

        public override void displayInfo()
        {
            Console.WriteLine("You order an Asia coffee!");
        }

        public override void displayPrice()
        {
            Console.WriteLine("The original price is {0}$", this.UnitPrice);
        }
    }
}
