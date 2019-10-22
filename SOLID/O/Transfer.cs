using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Transfer : IPayment
    {
        public decimal MakePayment(decimal amount)
        {
            Console.WriteLine("trabsfer");
            return amount;
        }
    }
}
