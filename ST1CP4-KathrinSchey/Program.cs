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
        // ################################################# global var
        public static string pay;
        public static string chooseDrink;
        public static string typPizza;
        public static string street;
        public static int housNumber;
        public static int doorNumber;
        public static int plz;
        public static string place;
        public static int phoneNumber;
        public static string name;
        

        enum SizePizza
        {
            small = 1,
            big,
            family
        }
        
        // ################################################# methods start

        public static void PaymentSystem() // <---- for the pay methods. use on line 212
        {
            
            Console.WriteLine("What payment method do you prefere?");
            Console.WriteLine("1- cash | 2- creditCard | 3- PayPall | 4- Bitcoin");
            
            pay = Console.ReadLine();  // <---- pay = global variable

            if (pay == "1")
                pay = "cash";
            else if (pay == "2")
                pay = "credit card";
            else if (pay == "3")
                pay = "PayPall";
            else if (pay == "4")
                pay = "BitCoin";
            else
            {
                pay = "cash";
            } 

        }
        
        

        public static void WhatTime()  // <---- use on line 205 
        {            
            Console.WriteLine("at what time shoud it be delivered?");
            Console.WriteLine("1 hour | 2 hour | asap! i am very hungry... (just enter 1,2 or 3)");
            string timeDelivery = Console.ReadLine();            
        }

        public static void TypeOfPizza()  // <---- use on lines 157, 167, 185
        {

            Console.WriteLine("1- magherita | 2- quattro formaggi | 3- tonno | 4- diavolo | 5- romana");
            typPizza = Console.ReadLine();

            switch (typPizza)
            {
                case "1":
                    Console.WriteLine($"You choosed Magherita good choice {name}");
                    typPizza = "Margherita";
                    break;
                case "2":
                    Console.WriteLine("quattro formaggi");
                    break;
                case "3":
                    Console.WriteLine("tonno");
                    break;
                case "4":
                    Console.WriteLine("diavolo");
                    break;
                case "5":
                    Console.WriteLine("romana");
                    break;
                default:
                    Console.WriteLine("nothing choose");
                    break;
            }
        }

        public static void PersonData() // <--- use on line 213
        {
            Console.WriteLine("Now, we need your adress and phone number");
            Console.WriteLine("At first, your street");
            street = Console.ReadLine();
            Console.WriteLine("now the haus number");
            housNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your door number");
            doorNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please, enter your plz");
            plz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and your place");
            place = Console.ReadLine();
            Console.WriteLine("at last, your phone number please. (without special character)");
            phoneNumber = Convert.ToInt32(Console.ReadLine());
        }


        // +++++++++++++++++++++++++++++++++++++++ main start
        static void Main(string[] args)
        { 
            // hello part :) 
            Console.WriteLine("Hi! Whats your name?");
            //Console.WriteLine("to serius?- press 1");
            //var serius = Convert.ToInt32(Console.ReadLine());
            /*
            if(serius == 1)
            {
                Console.WriteLine("Ok. Wish you a nice day!");
                System.Environment.Exit(0);
            }*/

            //Console.WriteLine("Ok. Not to sirius. fine :) ! Whats your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Welcome in our Casa Roma Trattoria! \n How are you today? (1- busy, but ok :) | 2- pretty good, thanks | 3- never been better :D )");
            var how = Convert.ToInt32(Console.ReadLine());

            if (how == 1) // in Eile

            {
                Console.WriteLine("Great. Woud you like to use our express-delivery service? (1- sounds good | 2- no hurry)");
                var express = Convert.ToInt32(Console.ReadLine());
                if (express == 1) // express Liefern JA
                {
                    Console.WriteLine("What type of pizza woud you like?");
                    TypeOfPizza();

                } else  //  Express KLiefern Nein
                {
                    Console.WriteLine("Woud you like to order some food? (1- yes please! | 2- not yet, yust wanted to chat)");
                    var orderFood = Convert.ToInt32(Console.ReadLine());

                    if (orderFood == 1) // Will Bestellen aber nicht express
                    {
                        Console.WriteLine("What type of pizza woud you like?");
                        TypeOfPizza();
                    }
                    else // Will nicht bestellen exit Chat Beenden Programm
                    {
                        Console.WriteLine("ok. wish you a nice day");
                        System.Environment.Exit(0);

                    }
                } // Kein Express Ende

            } else // user ist Chill und hat keine Eile Noch nicht nach bestellung gefragt
            {
                Console.WriteLine("Woud you like to order some food? (1- yes please! | 2- not yet, yust wanted to chat)");
                var orderFood = Convert.ToInt32(Console.ReadLine());

                if (orderFood == 1)
                {
                    Console.WriteLine("What type of pizza woud you like?");
                    TypeOfPizza();
                }
                else
                {
                    Console.WriteLine("ok. wish you a nice day");
                    System.Environment.Exit(0);
                }

            }

            Console.WriteLine("What size?");
            Console.WriteLine("1- small | 2- big | 3- family");
            var pizzaSize = Convert.ToInt32(Console.ReadLine());
            var printSize = (SizePizza)pizzaSize;

            Console.WriteLine("Woud you like to add some drinks to your order? (1- no, thanks | 2- yes please)");
            var askDrink = Convert.ToInt32(Console.ReadLine());

            if (askDrink == 1)
            {
                WhatTime();
                
            } else
            {
                TheMethods objChoosenDrinks = new TheMethods();
                
               chooseDrink = objChoosenDrinks.ChooseDrinks("0"); 
            }

            PaymentSystem();
            PersonData();

            Console.WriteLine($"Hi {name}, we are glad to show you the details of your order:");
            Console.WriteLine($"{typPizza}, {printSize}, {chooseDrink} to be delivered at");
            Console.WriteLine($"The method you coose is {pay}");
            Console.WriteLine($"street: {street} housenumber: {housNumber}");
            Console.WriteLine($"plz: {plz} city: {place}");
            Console.WriteLine($"your phonenumber is: {phoneNumber}");

        }
    }
}

