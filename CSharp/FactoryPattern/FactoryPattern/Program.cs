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
            //Console.WriteLine("enter card type :");
            //string cardType = Console.ReadLine();

            //ICreditCard cc = CreditCardFactory.GetCreditcard(cardType);


            //if(cc!=null)
            //{
            //    Console.WriteLine("Card Type : {0}", cc.GetCardType());
            //    Console.WriteLine("Card Limit : {0}", cc.GetCardLimit());
            //    Console.WriteLine("Annual Charges : {0}", cc.GetAnnualCharges());
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Card.. please give correct type");
            //}

            ICreditCard Icc = new ProductFactory.MoneyBackFactory().CreateProduct();
            if (Icc != null)
            {
                Console.WriteLine("Card Type : {0}", Icc.GetCardType());
                Console.WriteLine("Card Limit : {0}", Icc.GetCardLimit());
                Console.WriteLine("Annual Charges : {0}", Icc.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card.. please give correct type");
            }
            Console.WriteLine("---------------------");

            Icc = new ProductFactory.PlatinumFactory().CreateProduct();
            if (Icc != null)
            {
                Console.WriteLine("Card Type : {0}", Icc.GetCardType());
                Console.WriteLine("Card Limit : {0}", Icc.GetCardLimit());
                Console.WriteLine("Annual Charges : {0}", Icc.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card.. please give correct type");
            }
            Console.WriteLine("---------------------");

            Icc = new ProductFactory.TitaniumFactory().CreateProduct();
            if (Icc != null)
            {
                Console.WriteLine("Card Type : {0}", Icc.GetCardType());
                Console.WriteLine("Card Limit : {0}", Icc.GetCardLimit());
                Console.WriteLine("Annual Charges : {0}", Icc.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card.. please give correct type");
            }
            Console.WriteLine("---------------------");
            Console.Read();
        }
    }
}
