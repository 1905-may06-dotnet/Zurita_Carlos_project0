using System;
using System.Collections.Generic;
using System.Text;
using PizzaBox.Data.model;
namespace PizzaBox.Domain
{
    public class Pizza
    {
        //public object[] Size { get; set; }
        public string Size { get; set; }
        public int SizeCost { get; set; }
        //public object[] Crust { get; set; }
        public string Crust { get; set; }
        public int CrustCost { get; set; }
        public int Cost { get; set; }
        public List<string> Toppings { get; set; }

        public int CostCalc(int psizecost, int pcrustcost)
        {
            //int pcost = 0;
            //pcost = psizecost + pcrustcost;
            //pcost = Int32.Parse(psizecost);
            //return pcost;
            dynamic a = psizecost;
            dynamic b = pcrustcost;
            return a + b;
        }
        public Pizza(string Size, int SizeCost, string Crust, int CrustCost, int Cost, string Pepperoni, string Cheese, string Spinach, string Sausage, string Bacon)
        {
            this.Size = Size;
            this.SizeCost = SizeCost;
            this.Crust = Crust;
            this.CrustCost = CrustCost;
            //this.Cost = CostCalc(SizeCost, CrustCost);
            this.Cost = Cost;
            Toppings = new List<string>(){ Pepperoni, Cheese, Spinach, Sausage, Bacon };

            PizzaContext pbcontext = new PizzaContext();

            //int toppingid = 1;
            foreach (var Topping in Toppings)
            {
                pbcontext.Toppings.Add(new Toppings(PizzaRestaurant.tcounter, Topping));
                //pbcontext.Toppings.Add(new Toppings(1, Topping));
                PizzaRestaurant.tcounter += 1;
                Console.WriteLine($"Sent to SQL Database: {Topping}");
            }

            pbcontext.SaveChanges();

            //PizzaContext pbcontext = new PizzaContext();
            //Toppings topping1 = new Toppings();
            //topping1.Toppingid = 1;
            //topping1.Topping = Pepperoni;
            //pbcontext.Toppings.Add(new Toppings(1, Pepperoni));
            //pbcontext.Toppings.Add(new Toppings(2, Cheese));
            //PizzaContext pbcontext = new PizzaContext();
            //Toppings topping1 = new Toppings();
            //topping1.Toppingid = 1;
            //topping1.Topping = Pepperoni;
            //pbcontext.Toppings.Add(topping1);

            //Toppings topping2 = new Toppings();
            //topping2.Toppingid = 2;
            //topping2.Topping = "Sausage";
            //pbcontext.Toppings.Add(topping2);
            //pbcontext.SaveChanges();

            //Toppings = new List<string>();
            //List<string> list1 = new List<string>() { Pepperoni, Cheese, Spinach, Sausage, Bacon };

            //this.Cost = Cost;
        }
    }
}
