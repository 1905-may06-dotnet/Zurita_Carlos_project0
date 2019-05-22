using System;
using System.Collections.Generic;
using System.Text;
using PizzaBox.Data.model;
namespace PizzaBox.Domain
{
    public class PizzaRestaurant
    {
        public static int tcounter = 1;
        public static int pcounter = 1;
        public static int ucounter = 1;
        public static int CheckInput(int enumlength, int selsize)
        {
            int newsize;
            if (enumlength >= selsize)
            {
                if (selsize < 0)
                {
                    Console.WriteLine("Try Again");
                    //SizeSelection();
                    newsize = Int32.Parse(Console.ReadLine());
                    newsize = CheckInput(enumlength, newsize);
                    //CheckInput(3, 1);
                }
                else
                {
                    //Console.WriteLine("Good choice");
                    newsize = selsize;
                }
            }
            else
            {
                Console.WriteLine("Try Again");
                //SizeSelection();
                newsize = Int32.Parse(Console.ReadLine());
                newsize = CheckInput(enumlength, newsize);
                //CheckInput(3, 1);
            }
            return newsize;
        }
        public List<PizzaLocation> Locations { get; set; }
        public PizzaRestaurant()
        {
            Locations = new List<PizzaLocation>() { };
            //PizzaLocation Location1 = new PizzaLocation();
            Locations.Add(new PizzaLocation("Main Road", "2nd Street", "Houston", "Texas", "USA", 77123));
            Locations.Add(new PizzaLocation("First Street", "2nd Road", "Austin", "Texas", "USA", 77456));
            Locations.Add(new PizzaLocation("Simple Street", "Long Road", "Dallas", "Texas", "USA", 77789));

            //PizzaContext pbcontext = new PizzaContext();

            //pbcontext.Locations.Add(new Locations(1, "Main Road", "2nd Street", "Houston", "Texas", "USA", "77123", 1));
            //pbcontext.Locations.Add(new Locations(2, "First Street", "2nd Road", "Austin", "Texas", "USA", "77456", 2));
            //pbcontext.Locations.Add(new Locations(3, "Simple Street", "Long Road", "Dallas", "Texas", "USA", "77789", 3));
            ////PizzaRestaurant.pcounter += 1;
            //pbcontext.SaveChanges();

            //Locations.Add(new PizzaLocation());

            //Console.WriteLine($"List of Locations:");
            //int loccount = 1;
            //foreach (var Location in Locations)
            //{
            //    Console.WriteLine($"{loccount}. {Location.City} at {Location.Street1} by {Location.Street2}");
            //    loccount += 1;
            //}
        }
        public void NewUser(string city)
        {
            int signorreg = 0;
            Console.WriteLine("Would you like to sign in or register?\nPlease enter 0 to sign in and 1 to register");
            signorreg = Int32.Parse(Console.ReadLine());
            signorreg = PizzaRestaurant.CheckInput(1, signorreg);
            //string username = "carloszman43";
            //string password = "1920";
            //string firstname = "Carlos";
            //string lastname = "Zurita";
            //string location = "Houston";
            if (signorreg == 1)
            {
                Console.WriteLine("You selected to register");
                Console.Write("Please enter the username you would like: ");
                string userin = Console.ReadLine();
                Console.Write("Please enter the password you would like: ");
                string passin = Console.ReadLine();
                Console.Write("Please enter your first name: ");
                string firstn = Console.ReadLine();
                Console.Write("Please enter your last name: ");
                string lastn = Console.ReadLine();
                foreach (var Location in Locations)
                {
                    if (Location.City == city)
                    {
                        Location.Users.Add(new PizzaUser(userin, passin, firstn, lastn, city));

                        //PizzaContext pbcontext = new PizzaContext();

                        //pbcontext.Users.Add(new Users(1, ucounter, userin, passin, firstn, lastn));
                        //PizzaRestaurant.ucounter += 1;
                        //pbcontext.SaveChanges();

                        //Console.WriteLine(Location.City);
                        //foreach (var user in Location.Users)
                        //{
                        //    if (user.username == userin)
                        //    {
                        //        int reganother = 0;
                        //        Console.WriteLine("Would you like to place another order? You can only order once every 2 hours though.\nPlease enter 0 to to stop ordering and sign out. Enter 1 to continue ordering");
                        //        reganother = Int32.Parse(Console.ReadLine());
                        //        reganother = PizzaRestaurant.CheckInput(1, reganother);
                        //        if (reganother == 0)
                        //        {
                        //            Console.WriteLine("You are signed out now. Thanks for coming by.\n");
                        //        }
                        //        else
                        //        {
                        //            Console.WriteLine("Select a new order.\n");
                        //            user.Orders.Add(new PizzaOrder());
                        //        }
                        //    }
                        //    else
                        //    {

                        //    }
                        //}
                    }
                }
            }
            else
            {
                Console.WriteLine("You have selected to sign in");

                Console.Write("Please enter your username: ");
                string userin = Console.ReadLine();
                Console.Write("Please enter your password: ");
                string passin = Console.ReadLine();

                foreach (var Location in Locations)
                {
                    if (Location.City == city)
                    {
                        foreach (var user in Location.Users)
                        {
                            //Console.WriteLine(user);
                            
                            if (user.username == userin)
                            {
                                
                                if (user.password == passin)
                                {
                                    Console.WriteLine("You have signed in");
                                    Console.WriteLine("Your order history:");
                                    foreach (var order in user.Orders)
                                    {
                                        int totalcostoforder = 0;
                                        int pizzacount = 1;
                                        foreach (var pizza in order.Pizzas)
                                        {
                                            Console.WriteLine($"Pizza {pizzacount}: {pizza.Size} and {pizza.Crust} crust");
                                            Console.WriteLine($"Total cost of pizza: {pizza.Cost}\n");
                                            pizzacount += 1;
                                            totalcostoforder = totalcostoforder + pizza.Cost;
                                        }
                                        Console.WriteLine($"Total order cost: {totalcostoforder}");
                                    }
                                    Console.WriteLine("Would you like to place an order? Enter 1 for yes and 0 for no");
                                    int anotherorderin = Int32.Parse(Console.ReadLine());
                                    anotherorderin = PizzaRestaurant.CheckInput(1, anotherorderin);
                                    if (anotherorderin == 0)
                                    {
                                        Console.WriteLine("Ok. Thanks for coming by.\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Select a new order.\n");
                                        user.Orders.Add(new PizzaOrder());
                                    }
                                }
                            }
                            else
                            {

                            }
                            //Console.WriteLine(user.username);
                        }
                    }
                }
            }
            

            //Moved here
            //Users.Add(new PizzaUser(username, password, firstname, lastname, location));

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
