using System;
using System.Collections.Generic;

namespace PizzaBox.Data.model
{
    public partial class Pizzas
    {
        public Pizzas()
        {
            Orders = new HashSet<Orders>();
        }
        public Pizzas(int Pizzaid, string Size, string Crust, int Ptoppiongid, int Cost)
        {
            this.Pizzaid = Pizzaid;
            this.Size = Size;
            this.Crust = Crust;
            this.Ptoppiongid = Ptoppiongid;
            this.Cost = Cost;
        }

        public int Pizzaid { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public int Ptoppiongid { get; set; }
        public int Cost { get; set; }

        public virtual Toppings Ptoppiong { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
