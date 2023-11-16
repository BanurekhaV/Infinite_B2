using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEF_CodeFirst.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee enew);
        Employee UpdateEmployee(Employee echanges);
        Employee DeleteEmploye(int eid);
    }
}
