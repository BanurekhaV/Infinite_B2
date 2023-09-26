using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditcard(string cardType)
        {
            ICreditCard Icc = null;
            if (cardType == "MoneyBack")
            {
                Icc = new MoneyBack();
            }
            else if (cardType == "Platinum")
            {
                Icc = new Platinum();
            }
            else if (cardType == "Titanium")
            {
                Icc = new Titanium();
            }
            return Icc;
        }
    }
}
