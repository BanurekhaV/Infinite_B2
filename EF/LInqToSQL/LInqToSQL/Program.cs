using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInqToSQL
{
    class Program
    {
        static NorthWindDataDataContext ndc = new NorthWindDataDataContext();
        static void Main(string[] args)
        {
            var cat = ndc.Categories.ToList();

            foreach(var c in cat)
            {
                Console.WriteLine($"{c.CategoryID} {c.CategoryName}, {c.Description}");
            }
            Console.WriteLine("--------------------");
            var cust = ndc.Customers.ToList();

            foreach(var customer in cust)
            {
                Console.WriteLine($"{customer.ContactName},{customer.City}, {customer.Country}");
            }
            Console.Read();
            
        }
    }
}
