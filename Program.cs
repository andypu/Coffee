using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeProject
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Please input the type of the Coffee, A for Asia Coffee, E for Euro Coffee, I for Ice Coffee.");
            string typeInitial = Console.ReadLine();
            Console.WriteLine("Do you want to add sugar? Y for yes, N for No");
            string sugarOrNot = Console.ReadLine();
            Console.WriteLine("Do you want to add cream? Y for yes, N for No");
            string creamOrNot = Console.ReadLine();

            
            Coffee coffee;
            if(typeInitial.Equals("A")){
                coffee = new AsiaCoffee();
                coffee.displayInfo();
                coffee.displayPrice();

                if (sugarOrNot.Equals("Y"))
                {
                    coffee.addSugar();
                    Console.WriteLine("Add sugar, which is 0.5$");
                }
                if (creamOrNot.Equals("Y"))
                {
                    coffee.addCream();
                    Console.WriteLine("Add cream, which is 0.5$");
                }

                
                Console.WriteLine("The total price is: {0}$",coffee.UnitPrice);
                Console.ReadLine();
            }
            else if (typeInitial.Equals("E"))
            {
                coffee = new EuroCoffee();
                coffee.displayInfo();
                coffee.displayPrice();

                if (sugarOrNot.Equals("Y"))
                {
                    coffee.addSugar();
                    Console.WriteLine("Add sugar, which is 0.5$");
                }
                if (creamOrNot.Equals("Y"))
                {
                    coffee.addCream();
                    Console.WriteLine("Add cream, which is 0.5$");
                }


                Console.WriteLine("The total price is: {0}$", coffee.UnitPrice);
                Console.ReadLine();
            }
            else if (typeInitial.Equals("I"))
            {
                coffee = new IceCoffee();
                coffee.displayInfo();
                coffee.displayPrice();

                if (sugarOrNot.Equals("Y"))
                {
                    coffee.addSugar();
                    Console.WriteLine("Add sugar, which is 0.5$");
                }
                if (creamOrNot.Equals("Y"))
                {
                    coffee.addCream();
                    Console.WriteLine("Add cream, which is 0.5$");
                }


                Console.WriteLine("The total price is: {0}$", coffee.UnitPrice);
                Console.ReadLine();

            }

            

        }
    }
}
