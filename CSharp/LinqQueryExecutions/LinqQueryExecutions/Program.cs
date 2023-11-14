using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueryExecutions
{
    class Employee
    {
       public int ID;
       public String Name;
       public Double Salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {new Employee{ID=100,Name="AAA",Salary=30000},
            new Employee{ID=101,Name="BBB",Salary=42000},
            new Employee{ID=102,Name="CCC",Salary=54000},
            };

            //construction of a linq query (deferred)
            var emp = employees.Where(x => x.Salary < 35000).Select(y => y.Name);

            //let us add another record to the employees collection
            employees.Add(new Employee { ID = 103, Name = "DDD", Salary = 20000 });

            //query execution of deferred
            foreach(var e in emp)
            {
                Console.WriteLine(e);
            }

            /* 
             linq query construction as well as execution
             var emp = employees.Where(x => x.Salary < 35000).Select(y => y.Name).ToList();

            //let us add another record to the employees collection
            //the newly added record even though matches the criteria does not get selected
            employees.Add(new Employee { ID = 103, Name = "DDD", Salary = 20000 });

            //query execution of deferred
            foreach(var e in emp)
            {
                Console.WriteLine(e);
            } 
             */
           
            Console.ReadLine();
        }
            
    }
}
