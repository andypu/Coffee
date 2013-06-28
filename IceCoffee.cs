using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeProject
{
    class IceCoffee:Coffee
    {
        public IceCoffee() {
            this.UnitPrice = 4;
        }
        //public IceCoffee(string coffeeType, double unitPrice) : base(coffeeType, unitPrice) { }
        
        public override void displayInfo(){
            Console.WriteLine( "You order an Ice coffee!");
        }

        public override void displayPrice()
        {
            Console.WriteLine("The original price is {0}$", this.UnitPrice);
        }
    }
}
