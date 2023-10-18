using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqToSql_SqlMetal
{

    class Program
    {
       static string connStr = ConfigurationManager.ConnectionStrings["NwindConnString"].ConnectionString;
        static NorthwindContext db = new NorthwindContext(connStr);
        
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
