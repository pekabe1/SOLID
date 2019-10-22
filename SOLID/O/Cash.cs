using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class Cash : IPayment
    {
        public decimal MakePayment(decimal amout)
        {
            Console.WriteLine("cash");
            return 1;
        }
    }
}
