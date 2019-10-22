using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    class SOLID_O
    {

        public class Payment
        {
            public string Cash(decimal amount)
            {
                return $"Płatnośc gotówką - {amount}";
            }
            public string Transfer(decimal amount)
            {
                return $"Płatnośc przelewem - {amount}";
            }
            public string Card(decimal amount)
            {
                return $"Płatnośc kartą - {amount}";
            }
        }
    }
}
