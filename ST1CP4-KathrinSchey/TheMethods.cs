using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ST1CP4_KathrinSchey
{
    class TheMethods
    {
        /*
        public void ExpressDelivery()
        {
            
            var express = Convert.ToInt32(Console.ReadLine());

            if (express == 1)
                TypeOfPizza();
            else
                OrderFood();
        }*/

        /*
        public void OrderFood()
        {            
            var order = Convert.ToInt32(Console.ReadLine());

            if (order == 1)
                TypeOfPizza();
            else
                Console.WriteLine("Thank you. Wish you a nice day.");
        }*/


        /*

        Console.WriteLine("1- magherita | 2- quattro formaggi | 3- tonno | 4- diavolo | 5- romana");
                    var typPizza = Convert.ToInt32(Console.ReadLine());
        var printPizzaTyp = (TypPizza)typPizza;
        */

        /*
    public void DeliveryTime()
    {
        Console.WriteLine("at what time shoud it be delivered?");
        Console.WriteLine("1 hour | 2 hour | asap! i am very hungry...");
        string timeDelivery = Console.ReadLine();
    }*/

        /*
        public string Drinks(string drink)
        {
            Console.WriteLine("What drink you whana choose?");
            Console.WriteLine("juice | cola | beer");
            return drink;
        }*/

        public string ChooseDrinks(string choosenDrink)  // <----- for the drinks. use on line 209
        {
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

        public void Drinks()
        {
            ArrayList drinks = new ArrayList(new string[] {"1- juice", "2- cola", "3- beer"});

            for (int i = 0; i < drinks.Count; i++)
            {
                Console.Write(drinks[i] + " ");
            }
           
        }




        
        

        
    }
}
