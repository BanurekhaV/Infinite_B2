using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_pattern2
{
    //injector or service class
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }

    //Implementing class

    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
                new Employee(){ID=1, Name="Janani", Department="IT"},
                new Employee(){ID=2, Name="Nandini", Department="Finance"},
                new Employee(){ID=3, Name="Harini", Department="HR"}
            };
            return ListEmployees;
        }
    }

}
