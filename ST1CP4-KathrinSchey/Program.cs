using System;

namespace ST1CP4_KathrinSchey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! How are you today? (1- busy, but ok :) | 2- pretty good, thanks | 3- never been better :D )");
            var how = Convert.ToInt32(Console.ReadLine());
            
            if (how == 1)
            {
                Console.WriteLine("Great. Woud you like to use our express-delivery service? (1- sounds good | 2- no hurry)");
                TheMethods one = new TheMethods();
                one.ExpressDelivery();
            }

            if (how == 2 || how == 3)
            {
                Console.WriteLine("Woud you like to order some food? (1- yes please! | 2- not yet, yust wanted to chat)");
                TheMethods some = new TheMethods();
                some.OrderFood();
            }

            Console.WriteLine("What type of pizza woud you like?");
            TheMethods typePizza = new TheMethods();
            typePizza.TypeOfPizza();

            Console.WriteLine("What size? (small | big | super family big pizza)");
            string sizePizza = Console.ReadLine();

            Console.WriteLine("Woud you like to add some drinks to your order? (1- no, thanks | 2- yes please)");
            var askDrink = Convert.ToInt32(Console.ReadLine());

            if (askDrink == 1)
            {
                TheMethods one = new TheMethods();
                one.DeliveryTime();
            } else
            {
                TheMethods drink = new TheMethods();
                drink.Drinks();
                TheMethods delivery = new TheMethods();
                delivery.DeliveryTime();
            }

            TheMethods payment = new TheMethods();
            payment.PaymentSystem();

            TheMethods personData = new TheMethods();
            personData.PersonData();            

            Console.WriteLine($"Hi {name}, we are glad to show you the details of your order:");
            Console.WriteLine($"{typePizza}, {sizePizza}, {askDrink} , to be delivered at {personData}");
            Console.WriteLine($"The method you coose is {payment}");
            Console.WriteLine($"");
           




        }
    }
}
