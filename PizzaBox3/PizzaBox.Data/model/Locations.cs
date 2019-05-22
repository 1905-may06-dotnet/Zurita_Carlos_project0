using System;
using System.Collections.Generic;

namespace PizzaBox.Data.model
{
    public partial class Locations
    {
        public Locations(int Locationid, string Street1, string Street2, string City, string State, string Country, string Zipcode, int Userid)
        {
            this.Locationid = Locationid;
            this.Street1 = Street1;
            this.Street2 = Street2;
            this.City = City;
            this.State = State;
            this.Country = Country;
            this.Zipcode = Zipcode;
            this.Userid = Userid;
        }
        public int Locationid { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public int Userid { get; set; }

        public virtual Users User { get; set; }
    }
}
