using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class MoneyBack : ICreditCard
    {
        public double GetAnnualCharges()
        {
            return 500;
        }

        public int GetCardLimit()
        {
            return 15000;
        }

        public string GetCardType()
        {
            return "Money Back Card";
        }
    }
}
