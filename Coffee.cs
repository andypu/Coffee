using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeProject
{
    class Coffee
    {
        private string coffeeType;
        private static double unitPrice;

        public string CoffeeType {
            get {
                return coffeeType;
            }
            set {
                coffeeType = value;
            }
        }
        public double UnitPrice {
            get {
                return unitPrice;
            }
            set {
                unitPrice = value;
            }
        }

        public Coffee(){
            this.UnitPrice = 0;
        }

        //public Coffee(string coffeeType, double unitPrice)
        //{
        //    this.coffeeType = coffeeType;
        //    this.unitPrice = unitPrice;
        //}

        public virtual void displayInfo() {
            
        }

        public virtual void displayPrice()
        {
            
        }

        public void addSugar() {
            unitPrice += 0.5;
        }

        public void addCream() {
            unitPrice += 0.5;
        }

    }
}
