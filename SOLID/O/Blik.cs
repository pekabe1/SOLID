using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class BlikL : IPayment
    {
        public decimal MakePayment(decimal amount)
        {
            Console.WriteLine("blik zapłacono : " + amount);
            return amount;
        }
    }
}
