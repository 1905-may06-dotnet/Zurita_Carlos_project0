using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class PizzaUser
    {
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string location { get; set; }
        public List<PizzaOrder> Orders { get; set; }

        public PizzaUser(string username, string password, string firstname, string lastname, string location)
        {
            //Console.WriteLine("Pizza");
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.location = location;
            //this.username = "carloszman43";
            //this.password = "1920";
            //this.firstname = "Carlos";
            //this.lastname = "Zurita";
            //this.location = "Houston";
            //POrder.Add(new Pizza(sizesel, costofsels, crustselc, costofselc, totalpizzacost));
            //Pizza pizza1 = new Pizza(Size, SizeCost, Crust, CrustCost, Cost, Pepperoni, Cheese, Spinach, Sausage, Bacon);
            //Console.WriteLine(pizza1.Cost);
            Orders = new List<PizzaOrder>() { };
            //PizzaOrder Order1 = new PizzaOrder();
            //Pizzas = new List<Pizza>() { };
            //Pizzas.Add(new Pizza(Size, SizeCost, Crust, CrustCost, Cost, Pepperoni, Cheese, Spinach, Sausage, Bacon));
            //Pizzas.Add(new Pizza(Size, SizeCost, Crust, CrustCost, Cost, Pepperoni, Cheese, Spinach, Sausage, Bacon));
            Orders.Add(new PizzaOrder());
            //Orders.Add();

            foreach (var Order in Orders)
            {
                foreach (var Pizza in Order.Pizzas)
                {
                    Console.WriteLine($"{Pizza.Size}\n{Pizza.Crust}\n{Pizza.Cost}");
                }
                Console.WriteLine($"Total order cost: {Order.TotalCost}");

            }


            //Toppings = new List<string>();
            //List<string> list1 = new List<string>() { Pepperoni, Cheese, Spinach, Sausage, Bacon };

            //this.Cost = Cost;
        }
    }
}
