using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision.DataAccess
{
    public interface IEmployeeDAL
    {
         List<Employee> GetAllEmployees();
    }

    //implementor or concrete class that implements the Interface methods
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee>GetAllEmployees()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee{ID=1, Name="Rajesh",Department="IT"},
                  new Employee{ID=2, Name="Mahesh",Department="HR"},
                    new Employee{ID=3, Name="Sujesh",Department="Admin"}
            };
            return emplist;
        }
    }
}
