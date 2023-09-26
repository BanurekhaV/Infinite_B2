using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Platinum : ICreditCard
    {
        public double GetAnnualCharges()
        {
            return 1000;
        }

        public int GetCardLimit()
        {
            return 25000;
        }

        public string GetCardType()
        {
            return "Platinum Card";
        }
    }
}
