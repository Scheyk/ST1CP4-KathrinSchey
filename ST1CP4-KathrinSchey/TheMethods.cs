using System;
using System.Collections.Generic;
using System.Text;

namespace ST1CP4_KathrinSchey
{
    class TheMethods
    {
        public void ExpressDelivery()
        {            
            var express = Convert.ToInt32(Console.ReadLine());

            if (express == 1)
                TypeOfPizza();
            else
                OrderFood();
        }

        public void OrderFood()
        {            
            var order = Convert.ToInt32(Console.ReadLine());

            if (order == 1)
                TypeOfPizza();
            else
                Console.WriteLine("Thank you. Wish you a nice day.");
        }

        public void TypeOfPizza()
        {
            Console.WriteLine("magherita | quattro formaggi | tonno | diavolo | romana");
            string typPizza = Console.ReadLine();
        }

        public void DeliveryTime()
        {
            Console.WriteLine("at what time shoud it be delivered?");
            Console.WriteLine("1 hour | 2 hour | asap! i am very hungry...");
            string timeDelivery = Console.ReadLine();
        }

        public void Drinks()
        {
            Console.WriteLine("juice | cola | beer");
            string typeDrink = Console.ReadLine();
        }

        enum Payment
        {
             cash = 1,
             creditCard,
             PayPall,
             Bitcoin
        }

        public void PaymentSystem() 
        {
            Console.WriteLine("What payment method do you prefere?");
            Console.WriteLine("1- cash | 2- creditCard | 3- PayPall | 4- Bitcoin");
            var payMethod = Convert.ToInt32(Console.ReadLine());

            var theMethod = (Payment)payMethod;
        }

        public void PersonData()
        {
            Console.WriteLine("Now, we need your adress and phone number");
            Console.WriteLine("At first, your street");
            string street = Console.ReadLine();
            Console.WriteLine("now the haus number");
            var housNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your door number");
            var doorNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please, enter your plz");
            var plz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and your place");
            string place = Console.ReadLine();
            Console.WriteLine("at last, your phone number please. (without special character)");
            var phoneNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
