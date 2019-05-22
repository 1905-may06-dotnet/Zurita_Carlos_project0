using System;
using System.Collections.Generic;

namespace PizzaBox.Data.model
{
    public partial class Users
    {
        public Users()
        {
            Locations = new HashSet<Locations>();
            Orders = new HashSet<Orders>();
        }
        public Users(int Ulocationid, int Customerid, string Username, string Password, string Firstname, string Lastname)
        {
            this.Ulocationid = Ulocationid;
            this.Customerid = Customerid;
            this.Username = Username;
            this.Password = Password;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
        }

        public int Ulocationid { get; set; }
        public int Customerid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public virtual ICollection<Locations> Locations { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
