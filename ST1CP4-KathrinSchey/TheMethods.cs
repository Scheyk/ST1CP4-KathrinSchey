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

            Console.WriteLine("1- magherita | 2- quattro formaggi | 3- tonno | 4- diavolo | 5- romana");
            pizza = Console.ReadLine();

            switch (pizza)
            {
                case "1":                    
                    pizza = "Margherita";
                    break;
                case "2":
                    pizza = "quattro formaggi";
                    break;
                case "3":
                    pizza = "tonno";
                    break;
                case "4":
                    pizza = "diavolo";
                    break;
                case "5":
                    pizza = "romana";
                    break;
                default:
                    pizza = "no pizza...";
                    break;
            }
            return pizza;
        }

        // for the drinks. use on line 118 in the programm.cs
        public string ChooseDrinks(string choosenDrink)  
        {
            Regex regex = new Regex(@"^\d+$");
            
            Console.WriteLine("What drink you whana choose?");
           
            Drinks();

            choosenDrink = Console.ReadLine(); // <---- chooseDrink = global variable 

            if (choosenDrink == "1")
                choosenDrink = "juce";
            else if (choosenDrink == "2")
                choosenDrink = "cola";
            else if (choosenDrink == "3")
                choosenDrink = "beer";
            else
            {
                choosenDrink = "nothing to drink";
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
            Console.WriteLine("at what time shoud it be delivered?");
            Console.WriteLine("1 hour | 2 hour | asap! i am very hungry... (just enter 1,2 or 3)");
            delivery = Console.ReadLine();
            return delivery;
        }

        // for the pay methods. use on line 122 in the programm.cs
        public string PaymentSystem(string choosePay) 
        {

            Console.WriteLine("What payment method do you prefere?");
            Console.WriteLine("1- cash | 2- creditCard | 3- PayPall | 4- Bitcoin");

            choosePay = Console.ReadLine();  // <---- pay = global variable

            if (choosePay == "1")
                choosePay = "cash";
            else if (choosePay == "2")
                choosePay = "credit card";
            else if (choosePay == "3")
                choosePay = "PayPall";
            else if (choosePay == "4")
                choosePay = "BitCoin";
            else
            {
                choosePay = "cash";
            }

            return choosePay;
        }

    }
}
