using System;
using System.Collections.Generic;
using System.Collections;//for non-generic
using PizzaBox.Domain;
using PizzaBox.Data.model;
namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Revature Pizzas");
            PizzaRestaurant Restaurant1 = new PizzaRestaurant();
            int p = 1;
            while (p == 1)
            {
                Console.WriteLine($"List of Locations:");
                int loccount = 1;
                foreach (var Location in Restaurant1.Locations)
                {
                    Console.WriteLine($"{loccount}. {Location.City} at {Location.Street1} by {Location.Street2}");
                    loccount += 1;
                }
                Console.WriteLine("List of users and order history");
                foreach (var Location in Restaurant1.Locations)
                {
                    Console.WriteLine($"Location: { Location.City}");
                    foreach (var user in Location.Users)
                    {
                        Console.WriteLine($"Username: { user.username}");
                        foreach (var order in user.Orders)
                        {
                            foreach (var pizza in order.Pizzas)
                            {
                                Console.WriteLine($"Size: {pizza.Size} for ${pizza.SizeCost}");
                                Console.WriteLine($"Crust: {pizza.Crust} for ${pizza.CrustCost}");
                                Console.WriteLine($"Toppings:");
                                foreach (var Topping in pizza.Toppings)
                                {
                                    if (Topping == "")
                                    {

                                    }
                                    else
                                    {
                                        Console.WriteLine($"{Topping} for $2");
                                    }
                                }
                                Console.WriteLine($"Total cost of pizza: {pizza.Cost}\n");
                            }
                            Console.WriteLine($"Total order cost: {order.TotalCost}\n");
                        }
                    }
                }
                Console.WriteLine("Please select a location");
                //foreach (var Location in Restaurant1.Locations)
                //{
                //    Console.WriteLine($"{Location.City} at {Location.Street1} by {Location.Street2}");
                //}
                int userlocin = Int32.Parse(Console.ReadLine());
                userlocin = PizzaRestaurant.CheckInput(3, userlocin);
                //Console.WriteLine(usersizec);
                string userlocsel = "";
                if (userlocin == 1)
                {
                    userlocsel = "Houston";
                }
                else if (userlocin == 2)
                {
                    userlocsel = "Austin";
                }
                else if (userlocin == 3)
                {
                    userlocsel = "Dallas";
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.WriteLine(userlocsel);

                Restaurant1.NewUser(userlocsel);

                //later
                //Console.WriteLine("Would you like to place an order?");
                //int userorderin = Int32.Parse(Console.ReadLine());
                //userorderin = PizzaRestaurant.CheckInput(1, userorderin);
                ////Console.WriteLine(usersizec);

                //if (userorderin == 1)
                //{
                //    Console.WriteLine("You selected to place an order.");

                //}
                //else
                //{
                //    Console.WriteLine("Ok Have a nice day.");
                //    Console.Clear();
                //}
                //Console.WriteLine(userlocsel);
            }
        }
    }
}
