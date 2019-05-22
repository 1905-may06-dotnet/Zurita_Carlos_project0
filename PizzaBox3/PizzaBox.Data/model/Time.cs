using System;
using System.Collections.Generic;

namespace PizzaBox.Data.model
{
    public partial class Time
    {
        public Time()
        {
            Orders = new HashSet<Orders>();
        }

        public int Timeid { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
