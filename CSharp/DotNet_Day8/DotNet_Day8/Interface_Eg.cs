using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day8
{
   public interface ICustomer  // prefix I before the interface name
    {
        void PrintCustomer();
        int AddNos(int x, int y);        
    }

    interface ISupplier
    {
        void PrintSupplier();
    }
    class Customer : ICustomer, ISupplier
    {
        public int AddNos(int x, int y)
        {
            return x + y;
        }

        public void PrintCustomer()
        {
            Console.WriteLine("Interface ICustomer Print");
        }

        public void PrintSupplier()
        {
            Console.WriteLine("Interface ISupplier Print");
        }
    }
    class Interface_Eg
    {
        static void Main()
        {
            Customer cust = new Customer();
            Console.WriteLine("Customer and Supplier Printing using Customer Object");
            cust.PrintCustomer(); 
            cust.PrintSupplier();

            ICustomer ic;
            ic = new Customer();

            Console.WriteLine("Customer Printing using ICustomer Object");
            ic.PrintCustomer();
            
            ISupplier isupp;
            isupp = new Customer();
            Console.WriteLine("Supplier Printing using ISupplier Object");
            isupp.PrintSupplier();
            Console.Read();
        }
       
    }
}
