using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revision.DataAccess;

namespace Revision.BusinessAccess
{
    public class EmployeeBAL
    {
        public IEmployeeDAL empdal;

        public EmployeeBAL(IEmployeeDAL iedal)
        {
            empdal = iedal;
        }
        public List<Employee> GetEmployees()
        {                  
            return empdal.GetAllEmployees();            
        }

    }
}
