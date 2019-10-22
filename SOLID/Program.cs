using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IPayment payment = null;
            string input = Console.ReadLine();

            switch (input)
            {
                case "cash":
                    payment = new Cash();
                        break;
                case "card":
                    payment = new CreditCard();
                    break;
                case "blik":
                    payment = new BlikL();
                    break;
            }
            try
            {
                payment.MakePayment(15);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            


        }
    }
}
