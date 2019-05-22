using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class PizzaLocation
    {
        //public int Address { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Zipcode { get; set; }
        //public int password { get; set; }
        //public int firstname { get; set; }
        //public int lastname { get; set; }
        public List<PizzaUser> Users { get; set; }

        public PizzaLocation(string Street1, string Street2, string City, string State, string Country, int Zipcode)
        {
            this.Street1 = Street1;
            this.Street2 = Street2;
            this.City = City;
            this.State = State;
            this.Country = Country;
            this.Zipcode = Zipcode;
            Users = new List<PizzaUser>() { };
            //PizzaUser User1 = new PizzaUser();

            //Maybe move to another method
            //Users.Add(new PizzaUser());

            //foreach (var User in Users)
            //{
            //    Console.WriteLine(User.username);
            //    foreach (var Order in User.Orders)
            //    {
            //        int pizzacount = 0;
            //        foreach (var Pizza in Order.Pizzas)
            //        {
            //            pizzacount += 1;
            //            Console.WriteLine($"Pizza: {pizzacount}\nSize: {Pizza.Size} for {Pizza.SizeCost}\nCrust: {Pizza.Crust} for {Pizza.CrustCost}\nTotal cost of pizza: {Pizza.Cost}");
            //        }
            //        Console.WriteLine($"Total cost of order: {Order.TotalCost}");

            //    }
            //}
        }

    }
}
