using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class CreditCard : IPayment
    {
        public decimal MakePayment(decimal amount)
        {
            Console.WriteLine("card");
            return 1;
        }
    }
}
