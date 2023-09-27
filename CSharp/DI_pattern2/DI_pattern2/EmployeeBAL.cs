using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_pattern2
{
    public class EmployeeBAL
    {
        public IEmployeeDAL iemployeeDAL;

        public EmployeeBAL(IEmployeeDAL edal)
        {
            iemployeeDAL = edal;
        }

        public List<Employee> GetAllEmployees()
        {
            return iemployeeDAL.SelectAllEmployees();
        }
    }
}
