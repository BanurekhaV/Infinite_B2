using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter card type :");
            string cardType = Console.ReadLine();

            ICreditCard cc = CreditCardFactory.GetCreditcard(cardType);

            
            if(cc!=null)
            {
                Console.WriteLine("Card Type : {0}", cc.GetCardType());
                Console.WriteLine("Card Limit : {0}", cc.GetCardLimit());
                Console.WriteLine("Annual Charges : {0}", cc.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card.. please give correct type");
            }
            Console.Read();
        }
    }
}
