using System;
using System.Collections.Generic;
using SOLID.D;
namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //IPayment payment = null;
            //string input = Console.ReadLine();

            //switch (input)
            //{
            //    case "cash":
            //        payment = new Cash();
            //            break;
            //    case "card":
            //        payment = new CreditCard();
            //        break;
            //    case "blik":
            //        payment = new BlikL();
            //        break;
            //}
            //try
            //{
            //    payment.MakePayment(15);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();



            List<IMessage> messages = new List<IMessage>();

            messages.Add(new Sms());
            messages.Add(new Email());
            messages.Add(new Mms());

            foreach (IMessage item in messages)
            {
                item.Send("message");
                Console.WriteLine(item.Send("message"));
            }
            Console.ReadLine();

            

        }
    }
}
