using System;
using System.Globalization;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http.Headers;

namespace ST1CP4_KathrinSchey
{
    class Program
    {
        // global var
        public static string pay;
        public static string chooseDrink;
        public static string typPizza;
        public static string timeDelivery;

        // enum for pizza size
        enum SizePizza
        {
            small = 1,
            big,
            family
        }
       
        static void Main(string[] args)
        {
            // bring the class "TheMethods" in, to use it later in the code
            TheMethods objTheMethods = new TheMethods();

            // hello part :) 
            Console.WriteLine("Hi! Whats your name? (or exit)");            
            string name = Console.ReadLine();
            
            if(name == "exit")
            {
                Console.WriteLine("Ok. Wish you a nice day!");
                System.Environment.Exit(0);
            }

            if (name == "")
                name = "Mr. sirius";
            
            Console.WriteLine($"Hello {name}! Welcome in our Casa Roma Trattoria! \n How are you today? (1- busy, but ok :) | 2- pretty good, thanks | 3- never been better :D )");
            var how = Convert.ToInt32(Console.ReadLine());

            if (how == 1) // <--- go in by busy

            {
                Console.WriteLine("Great. Woud you like to use our express-delivery service? (1- sounds good | 2- no hurry)");
                var express = Convert.ToInt32(Console.ReadLine());

                if (express == 1) // <--- express delivery "yes"
                {
                    Console.WriteLine("What type of pizza woud you like?");
                    // call the method "TypOfPizza" (is in TheMethod class. start: line 14)
                    typPizza = objTheMethods.TypeOfPizza("pizzaTyp"); 

                } else  //  <--- no hurry 
                {
                    Console.WriteLine("Woud you like to order some food? (1- yes please! | 2- not yet, yust wanted to chat)");
                    var orderFood = Convert.ToInt32(Console.ReadLine());

                    if (orderFood == 1) // Will Bestellen aber nicht express
                    {
                        Console.WriteLine("What type of pizza woud you like?");
                        // call the method "TypOfPizza" (is in TheMethod class. start: line 14)
                        typPizza = objTheMethods.TypeOfPizza("pizzaTyp");
                    }
                    else // <--- user wont order. exit
                    {
                        Console.WriteLine("ok. wish you a nice day");
                        System.Environment.Exit(0);

                    }
                } // <--- end

            } else // <--- user chill. user enterd 2 or 3. so he is relax.
            {
                Console.WriteLine("Woud you like to order some food? (1- yes please! | 2- not yet, yust wanted to chat)");
                var orderFood = Convert.ToInt32(Console.ReadLine());

                if (orderFood == 1)
                {
                    Console.WriteLine("What type of pizza woud you like?");
                    //  call the method "TypOfPizza" (is in TheMethod class. start: line 14)
                    typPizza = objTheMethods.TypeOfPizza("pizzaTyp");  
                }
                else
                {   //  user wont order. exit
                    Console.WriteLine("ok. wish you a nice day");
                    System.Environment.Exit(0);
                }

            }

            // ask pizza size
            Console.WriteLine("What size?");
            Console.WriteLine("1- small | 2- big | 3- family");
            var pizzaSize = Convert.ToInt32(Console.ReadLine());
            var printSize = (SizePizza)pizzaSize;

            // ask drinks
            Console.WriteLine("Woud you like to add some drinks to your order? (1- no, thanks | 2- yes please)");
            var askDrink = Convert.ToInt32(Console.ReadLine());

            if (askDrink == 1) // <--- if drink no
            {
                chooseDrink = "no Drink";
                // call the method "WhatTime"(is in TheMethod class. start: line 78)
                timeDelivery = objTheMethods.WhatTime("deliveryTime"); 

            } else  // <--- if drink yes
            {
                // call the method "ChooseDrinks"(is in TheMethod class. start: line 44)              
                chooseDrink = objTheMethods.ChooseDrinks("theDrink");

                // call the method "WhatTime"(is in TheMethod class. start: line 78)
                timeDelivery = objTheMethods.WhatTime("deliveryTime"); 
            }

            // call the method "PaymentSystem"(is in TheMethod class. start: line 86)
            pay = objTheMethods.PaymentSystem("thePayment"); 

            // start with the personal question
            if(name == "Mr. sirius")
            {
                Console.WriteLine("for order, please enter your correct name");
                name = Console.ReadLine();
            }

            Console.WriteLine("Now, we need your adress and phone number \n");
            Console.WriteLine("At first, your street");
            string street = Console.ReadLine();
            Console.WriteLine("now, the haus number");
            var housNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your door number");
            var doorNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please, enter your plz");
            var plz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and your place");
            string place = Console.ReadLine();
            Console.WriteLine("at last, your phone number please. (without special character)");
            var phoneNumber = Convert.ToInt32(Console.ReadLine());
            // end with the personal question
            Console.WriteLine("------------------------------------------------------------------------------- \n");
            
            // show the order details
            Console.WriteLine($"Hi {name}, we are glad to show you the details of your order:");
            Console.WriteLine($"Your pizza: {typPizza}, pizza size: {printSize}, your choosen drink: {chooseDrink}");
            Console.WriteLine($"The method to pay you wish is: {pay}");
            Console.WriteLine($"The adress you us give is: \n");
            Console.WriteLine($"Street: {street} \nHousenumber: {housNumber}");
            Console.WriteLine($"plz: {plz}, city: {place}");
            Console.WriteLine($"Your phonenumber is: {phoneNumber} \n");
            Console.WriteLine($"Thank's {name} for ordering! We call ya 5 min prior to arrival. Grazie mille!! \n");
            Console.WriteLine("-------------------------------------------------------------------------------");

        }
    }
}

