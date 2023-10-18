using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqToSql_SqlMetal
{
    class Program
    {
        static NorthwindContext db = new NorthwindContext();
        
        static void Main(string[] args)
        {
            var emp = from e in db.Employees
                      orderby e.FirstName
                      select e;

            //or

           // var emp1 = db.Employees.ToList();
            foreach(var v in emp)
            {
                Console.WriteLine($"{v.EmployeeID}, {v.FirstName}, {v.LastName}, {v.HireDate}");
            }
            Console.Read();
        }
    }
}
