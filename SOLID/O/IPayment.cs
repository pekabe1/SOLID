using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    interface IPayment
    {
        decimal MakePayment(decimal amount);
    }
}
