using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;

namespace ST1CP4_KathrinSchey
{
    class TheMethods
    {

        // use on lines 58, 71, 90
        public string TypeOfPizza(string pizza)  
        {
            Regex regex = new Regex(@"^\d+$");

            Console.WriteLine("1- magherita | 2- quattro formaggi | 3- tonno | 4- diavolo | 5- romana");

            try
            {
                pizza = Console.ReadLine();

                if (regex.IsMatch(pizza))
                {
                    var newPizza = Int32.Parse(pizza);
                    if (newPizza < 1 || newPizza > 5)
                    {
                        Console.WriteLine("we have only the five pizzen...");
                        TypeOfPizza("newStart");
                    } 
                }
                else
                {
                    Console.WriteLine("entered a string. not a number.");
                    TypeOfPizza("newStart");
                }

                if(pizza == "1")
                    pizza = "Margherita";
                else if(pizza == "2")
                    pizza = "quattro formaggi";
                else if(pizza == "3")
                    pizza = "tonno";
                else if(pizza == "4")
                    pizza = "diavolo";
                else 
                    pizza = "romana";

            } catch(Exception info)
            {
                Console.WriteLine(info);
            }

            return pizza;
        }

        // for the drinks. use on line 118 in the programm.cs
        public string ChooseDrinks(string choosenDrink)  
        {
            Regex regex = new Regex(@"^\d+$");

            Console.WriteLine("What drink you whana choose?");

            Drinks();

            try
            {
                choosenDrink = Console.ReadLine();

                if (regex.IsMatch(choosenDrink))
                {
                    var newChoosNumber = Int32.Parse(choosenDrink);
                    if (newChoosNumber < 1 || newChoosNumber > 3)
                    {
                        Console.WriteLine("only from 1 to 3");
                        ChooseDrinks("startNew");
                    } 
                }
                else
                {
                    Console.WriteLine("What u entered is a string, not a number, try again");
                    ChooseDrinks("startNew");
                }

                if (choosenDrink == "1")
                    choosenDrink = "juce";
                else if (choosenDrink == "2")
                    choosenDrink = "cola";
                else 
                    choosenDrink = "beer";
                
            }
            catch (Exception info)
            {
                Console.WriteLine(info);
            }
            
            return choosenDrink;
        }

        // for the ChooseDring method. a saparates array for the drinks
        public void Drinks()
        {
            ArrayList drinks = new ArrayList(new string[] {"1- juice", "2- cola", "3- beer"});

            for (int i = 0; i < drinks.Count; i++)
            {
                Console.Write(drinks[i] + " ");
            }
           
        }

        //  use on line 113 in the programm.cs
        public string WhatTime(string delivery)  
        {
            Regex regex = new Regex(@"^\d+$");

            Console.WriteLine("at what time shoud it be delivered?");
            Console.WriteLine("1 hour | 2 hour | asap! i am very hungry... (just enter 1,2 or 3)");
            try
            {
                delivery = Console.ReadLine();

                if (regex.IsMatch(delivery))
                {
                    var newDelivery = Int32.Parse(delivery);
                    if (newDelivery < 1 || newDelivery > 3)
                    {
                        Console.WriteLine("we have no more options. try again");
                        WhatTime("startAgain");
                    }
                    
                } else
                {
                    Console.WriteLine("you entered a string. please enter a number between 1 and 3");
                    WhatTime("startAgain");
                }

                if (delivery == "1")
                    delivery = "around 1 hour";
                else if (delivery == "2")
                    delivery = "around 2 hour";
                else
                    delivery = "so fast we can- cause you are verry hungry.";

            } catch(Exception info)
            {
                Console.WriteLine(info);
            }

            return delivery;
        }

        // for the pay methods. use on line 122 in the programm.cs
        public string PaymentSystem(string choosePay) 
        {
            Regex regex = new Regex(@"^\d+$");

            Console.WriteLine("What payment method do you prefere?");
            Console.WriteLine("1- cash | 2- creditCard | 3- PayPall | 4- Bitcoin");
            try
            {
                choosePay = Console.ReadLine();

                if (regex.IsMatch(choosePay))
                {
                    var newPay = Int32.Parse(choosePay);
                    if (newPay < 1 || newPay > 4)
                    {
                        Console.WriteLine("We have only this 4 methods. try again");
                        PaymentSystem("startAgain");
                    } 
                } else
                {
                    Console.WriteLine("you entered a string. please enter a number between 1 and 4");
                    PaymentSystem("startAgain");
                }

                if (choosePay == "1")
                    choosePay = "cash";
                else if (choosePay == "2")
                    choosePay = "credit card";
                else if (choosePay == "3")
                    choosePay = "PayPall";
                else 
                    choosePay = "BitCoin";               

            } catch(Exception info)
            {
                Console.WriteLine(info);
            }

            return choosePay;
        }

    }
}
