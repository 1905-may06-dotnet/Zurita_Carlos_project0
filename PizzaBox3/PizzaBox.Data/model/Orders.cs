using System;
using System.Collections.Generic;

namespace PizzaBox.Data.model
{
    public partial class Orders
    {
        public int Orderid { get; set; }
        public int Ocustomerid { get; set; }
        public int Otimeid { get; set; }
        public int Opizzaid { get; set; }

        public virtual Users Ocustomer { get; set; }
        public virtual Pizzas Opizza { get; set; }
        public virtual Time Otime { get; set; }
    }
}
