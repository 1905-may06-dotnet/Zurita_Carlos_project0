using System;
using System.Collections.Generic;
using System.Text;
//using PizzaBox.Data;
using PizzaBox.Data.model;
namespace PizzaBox.Domain
{
    public class PizzaOrder
    {
        //Crud c = new Crud();
        public int TotalCost { get; set; }
        public List<Pizza> Pizzas { get; set; }

        //public int CostCalc(int psizecost, int pcrustcost)
        //{
        //    //int pcost = 0;
        //    //pcost = psizecost + pcrustcost;
        //    //pcost = Int32.Parse(psizecost);
        //    //return pcost;
        //    dynamic a = psizecost;
        //    dynamic b = pcrustcost;
        //    return a + b;
        //}
        public string SelectSize()
        {
            string sizesels = "Small";
            //int costofsels = 0;
            int usersize;
            //string sizesels;
            //sizesels = "Small";
            Console.WriteLine("Select a size from the following options. Enter the corresponding number to the option you want.\n1. Small\n2. Medium\n3. Large");
            usersize = Int32.Parse(Console.ReadLine());
            usersize = PizzaRestaurant.CheckInput(3, usersize);
            //Console.WriteLine(usersize);

            if (usersize == 1)
            {
                sizesels = "Small";
            }
            else if (usersize == 2)
            {
                sizesels = "Medium";
            }
            else if (usersize == 3)
            {
                sizesels = "Large";
            }
            else
            {
                Console.WriteLine("Error");
            }
            return sizesels;
        }
        public string SelectCrust()
        {
            string sizeselc = "Thin";
            //int costofsels = 0;
            int usersizec;
            //string sizeselc;
            //sizeselc = "Small";
            Console.WriteLine("Select a crust type from the following options. Enter the corresponding number to the option you want.\n1. Thin\n2. Flat\n3. Thick");
            usersizec = Int32.Parse(Console.ReadLine());
            usersizec = PizzaRestaurant.CheckInput(3, usersizec);
            //Console.WriteLine(usersizec);

            if (usersizec == 1)
            {
                sizeselc = "Thin";
            }
            else if (usersizec == 2)
            {
                sizeselc = "Flat";
            }
            else if (usersizec == 3)
            {
                sizeselc = "Thick";
            }
            else
            {
                Console.WriteLine("Error");
            }
            return sizeselc;
        }
        public List<string> SelectToppings()
        {
            //int caseSwitch = 1;
            string Pepperoni = "";
            string Cheese = "";
            string Spinach = "";
            string Sausage = "";
            string Bacon = "";

            Console.WriteLine($"You can select from two default toppings lists or select your own toppings.\nInput 1 for default 1, 2 for default 2, and 3 to select your own toppings.");
            Console.WriteLine($"The available toppings include: Pepperoni, Cheese, Spinach, Sausage, Bacon.\nEach adds $2 to your total cost.");
            Console.WriteLine($"Default 1 adds pepperoni and cheese for $4.\nDefault 2 adds cheese, spinach, and sausage for $6");
            int caseSwitch1 = Int32.Parse(Console.ReadLine());
            switch (caseSwitch1)
            {
                case 1:
                    {
                        Console.WriteLine("Default 1");
                        Pepperoni = "Pepperoni";
                        Cheese = "Cheese";
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Default 2");
                        Cheese = "Cheese";
                        Spinach = "Spinach";
                        Sausage = "Sausage";
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Select your own toppings.");
                        Console.WriteLine($"Would you like Pepperoni for $2? Please input 1 for yes and 2 for no.");
                        int caseSwitch = Int32.Parse(Console.ReadLine());
                        switch (caseSwitch)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Added");
                                    Pepperoni = "Pepperoni";
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Not added");
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Default case");
                                }
                                break;
                        }
                        Console.WriteLine($"Would you like Cheese for $2? Please input 1 for yes and 2 for no.");
                        caseSwitch = Int32.Parse(Console.ReadLine());
                        switch (caseSwitch)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Added");
                                    Cheese = "Cheese";
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Not added");
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Default case");
                                }
                                break;
                        }
                        Console.WriteLine($"Would you like Spinach for $2? Please input 1 for yes and 2 for no.");
                        caseSwitch = Int32.Parse(Console.ReadLine());
                        switch (caseSwitch)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Added");
                                    Spinach = "Spinach";
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Not added");
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Default case");
                                }
                                break;
                        }
                        Console.WriteLine($"Would you like Sausage for $2? Please input 1 for yes and 2 for no.");
                        caseSwitch = Int32.Parse(Console.ReadLine());
                        switch (caseSwitch)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Added");
                                    Sausage = "Sausage";
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Not added");
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Default case");
                                }
                                break;
                        }
                        Console.WriteLine($"Would you like Bacon for $2? Please input 1 for yes and 2 for no.");
                        caseSwitch = Int32.Parse(Console.ReadLine());
                        switch (caseSwitch)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Added");
                                    Bacon = "Bacon";
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Not added");
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Default case");
                                }
                                break;
                        }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Default case");
                    }
                    break;
            }

            
            List<string> stringList = new List<string>() { Pepperoni, Cheese, Spinach, Sausage, Bacon };
            return stringList;
        }
        public PizzaOrder()
        {
            int confirmin = 0;
            do
            {
            this.TotalCost = 0;
            //Console.WriteLine("Pizza");
            //string Size = "";
            //int SizeCost = 0;
            //string Crust = "";
            //int CrustCost = 0;
            int Cost = 0;
            string Pepperoni = "";
            string Cheese = "";
            string Spinach = "";
            string Sausage = "";
            string Bacon = "";

            //string Size = "Small";
            //int SizeCost = 6;
            //string Crust = "Thin";
            //int CrustCost = 6;
            //int Cost = 0;
            //string Pepperoni = "Pepperoni";
            //string Cheese = "Cheese";
            //string Spinach = "";
            //string Sausage = "";
            //string Bacon = "";
            //POrder.Add(new Pizza(sizesel, costofsels, crustselc, costofselc, totalpizzacost));
            //Pizza pizza1 = new Pizza(Size, SizeCost, Crust, CrustCost, Cost, Pepperoni, Cheese, Spinach, Sausage, Bacon);
            //Console.WriteLine(pizza1.Cost);

            Pizzas = new List<Pizza>() { };
            //begin
            int anotherone = 1;
            int numofpizzas = 1;
            int totalpizzacost = 0;
            int totalordercost = 0;
            Console.WriteLine("The maximum amount of money you can spend with one order is $5000. The maximum amount of pizzas you can order is 100.");
            do
            {
                string sizesel = SelectSize();
                //Console.WriteLine($"Last: {sizesel}\n\n");
                string crustselc = SelectCrust();
                int costofsels = 0;
                int costofselc = 0;
                if (sizesel == "Small")
                {
                    costofsels = 6;
                }
                else if (sizesel == "Medium")
                {
                    costofsels = 12;
                }
                else if (sizesel == "Large")
                {
                    costofsels = 20;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                if (crustselc == "Thin")
                {
                    costofselc = 6;
                }
                else if (crustselc == "Flat")
                {
                    costofselc = 12;
                }
                else if (crustselc == "Thick")
                {
                    costofselc = 20;
                }
                else
                {
                    Console.WriteLine("Error");
                }
                totalpizzacost = costofsels + costofselc;

                List<string> ToppingsSel = SelectToppings();
                foreach (var Topping in ToppingsSel)
                {
                    if (Topping == "")
                    {
                        totalpizzacost += 0;
                    }
                    else if (Topping == "Pepperoni")
                    {
                        Pepperoni = "Pepperoni";
                        totalpizzacost += 2;
                    }
                    else if (Topping == "Cheese")
                    {
                        Cheese = "Cheese";
                        totalpizzacost += 2;
                    }
                    else if (Topping == "Spinach")
                    {
                        Spinach = "Spinach";
                        totalpizzacost += 2;
                    }
                    else if (Topping == "Sausage")
                    {
                        Sausage = "Sausage";
                        totalpizzacost += 2;
                    }
                    else if (Topping == "Bacon")
                    {
                        Bacon = "Bacon";
                        totalpizzacost += 2;
                    }
                    else
                    {
                        totalpizzacost += 2;
                    }
                    
                }

                //Console.WriteLine($"You selected: {sizesel}\nYour cost: {costofsels}\n");
                //Console.WriteLine($"You selected: {crustselc}\nYour cost: {costofselc}\n");
                
                totalordercost = totalordercost + totalpizzacost;
                //Pizzas.Add(new Pizza(sizesel, costofsels, crustselc, costofselc, totalpizzacost));
                //Pizzas.Add(new Pizza(sizesel, costofsels, crustselc, costofselc, Cost, Pepperoni, Cheese, Spinach, Sausage, Bacon));
                Pizzas.Add(new Pizza(sizesel, costofsels, crustselc, costofselc, totalpizzacost, Pepperoni, Cheese, Spinach, Sausage, Bacon));
                //List<string> Toppingslist = new List<string>();
                //c.AddToppings(Toppingslist);
                //POrder.Add(new Pizza("Medium", 12, "Flat", 12));
                ////POrder.Add(new Pizza(sizeselc, costofselc, "Flat", 12));
                //POrder.Add(new Pizza("Large", 20, "Thick", 20));

                PizzaContext pbcontext = new PizzaContext();

                pbcontext.Pizzas.Add(new Pizzas(PizzaRestaurant.pcounter, sizesel, crustselc, PizzaRestaurant.tcounter, totalpizzacost));
                PizzaRestaurant.pcounter += 1;
                pbcontext.SaveChanges();

                Console.WriteLine("Number of pizzas in order: {0}", numofpizzas);
                Console.WriteLine("Total cost of order so far: {0}", totalordercost);
                //totalordercost = totalordercost + 50;
                //totalordercost += totalordercost;

                //Console.WriteLine("Total order cost: {0}", totalordercost);
                if (numofpizzas == 100)
                {
                    Console.WriteLine("Ok. Thanks for ordering.\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Would you like another pizza? Enter 1 for yes and anything else for no.");
                    anotherone = Int32.Parse(Console.ReadLine());
                    if (anotherone != 1)
                    {
                        Console.WriteLine("Ok.\n");
                        break;
                    }
                    else
                    {
                        numofpizzas++;
                    }
                }

            } while (numofpizzas <= 100 && totalordercost <= 5000);
            this.TotalCost = totalordercost;
            //end


            //Pizzas.Add(new Pizza(Size, SizeCost, Crust, CrustCost, Cost, Pepperoni, Cheese, Spinach, Sausage, Bacon));
            //Pizzas.Add(new Pizza("Medium", 12, "Flat", 12, 0, "", "", "Spinach", "Sausage", "Bacon"));
            //Pizzas.Add(new Pizza(Size, SizeCost, Crust, CrustCost, Cost, Pepperoni, Cheese, Spinach, Sausage, Bacon));

            //foreach (var Pizza in Pizzas)
            //{
            //    //Console.WriteLine(Pizza.Size);
            //    this.TotalCost += Pizza.Cost;
            //    //Console.WriteLine(TotalCost);
            //}

            Console.WriteLine("Order Preview");
            foreach (var Pizza in Pizzas)
            {
                Console.WriteLine($"Size: {Pizza.Size} for ${Pizza.SizeCost}");
                Console.WriteLine($"Crust: {Pizza.Crust} for ${Pizza.CrustCost}");
                Console.WriteLine($"Toppings:");
                foreach (var Topping in Pizza.Toppings)
                {
                    if (Topping == "")
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine($"{Topping} for $2");
                    }
                }
                Console.WriteLine($"Total cost of pizza: {Pizza.Cost}\n");
            }
            Console.WriteLine($"Total order cost: {this.TotalCost}\n");
            //Finish soon
            Console.WriteLine("Would you like to confirm your order? Enter 1 for yes and 0 for no");
            confirmin = Int32.Parse(Console.ReadLine());
            confirmin = PizzaRestaurant.CheckInput(1, confirmin);
            if (confirmin == 0)
            {
                Console.WriteLine("Select a new order.\n");
            }
            else
            {
                Console.WriteLine("Ok. Thanks for ordering.\n");
            }

                //------------------------------
                //Toppings = new List<string>();
                //List<string> list1 = new List<string>() { Pepperoni, Cheese, Spinach, Sausage, Bacon };

                //this.Cost = Cost;
            }while (confirmin == 0);
        }
    }
}
