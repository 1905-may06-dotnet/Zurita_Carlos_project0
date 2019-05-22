using PizzaBox.Data.model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Data
{
    public class Crud
    {
        public List<Toppings> GetToppings()
        {
            // var restaurants=  from r in db.Restaurant
            //select r;

            var toppings = DbInstance.Instance.Toppings.ToList();
            return toppings;
        }

        public Toppings GetToppings(int Toppingid)
        {
            // RestaurantContext db = new RestaurantContext();
            // var restaurants=  from r in db.Restaurant
            //select r;

            var toppings = DbInstance.Instance.Toppings.Where<Toppings>(r => r.Toppingid == Toppingid).FirstOrDefault();
            return toppings;
        }

        public void AddToppings(Toppings r)
        {
            // RestaurantContext db = new RestaurantContext();
            DbInstance.Instance.Toppings.Add(r);// calling insert Query
            DbInstance.Instance.SaveChanges();
            Console.WriteLine($"Restaurant {r.Topping} added into Db");
        }
        public void DeleteToppings(Toppings r)
        {
            //RestaurantContext db = new RestaurantContext();
            var toppings = DbInstance.Instance.Toppings.Where<Toppings>(x => x.Toppingid == r.Toppingid).FirstOrDefault();
            DbInstance.Instance.Toppings.Remove(toppings);
            DbInstance.Instance.SaveChanges();
        }
    }
}