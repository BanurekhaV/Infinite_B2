using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Titanium : ICreditCard
    {
        public double GetAnnualCharges()
        {
            return 2000;
        }

        public int GetCardLimit()
        {
            return 50000;
        }

        public string GetCardType()
        {
            return "Titanium Card";
        }
    }
}
