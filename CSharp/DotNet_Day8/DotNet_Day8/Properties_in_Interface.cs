using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day8
{
    interface IGeneral
    {
        string Name { get; set; } // property declaration
    }

    class Employee : IGeneral
    {
        //automatic implementation of the interface property
        public string Name { get; set; }  //_Name private field gets created
    }

    class Company : IGeneral
    {
        string CompanyName { get; set; }
        public int EstablishedYears { get; set; } 
        //manual implementation of the interface property
        public string Name
        {
            get
            {
                return CompanyName;
            }
            set
            {
                CompanyName = value;
            }
        }

    }
    class Properties_in_Interface
    {
        static void Main()
        {
            IGeneral ig = new Employee();
            ig.Name = "Arpitha";

            IGeneral ig2 = new Company();
            ig2.Name = "Infinite";

            Company c = new Company();
            c.EstablishedYears = 13;
            
            Console.WriteLine("Employee {0} Works for the Company {1}, which is Established in the year {2}", ig.Name, ig2.Name, c.EstablishedYears);
            Console.Read();
        }
    }
}
