using System;
using System.Collections.Generic;

namespace PizzaBox.Data.model
{
    public partial class Toppings
    {
        public Toppings()
        {
            Pizzas = new HashSet<Pizzas>();
        }

        public Toppings(int Toppingid, string Topping)
        {
            this.Toppingid = Toppingid;
            this.Topping = Topping;
        }

        public int Toppingid { get; set; }
        public string Topping { get; set; }

        public virtual ICollection<Pizzas> Pizzas { get; set; }
    }
}
