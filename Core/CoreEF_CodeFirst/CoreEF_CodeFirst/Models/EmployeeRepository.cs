using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEF_CodeFirst.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext db;

        //constructor
        public EmployeeRepository(EmployeeDbContext context)
        {
            db = context;
        }
        public Employee AddEmployee(Employee enew)
        {
            db.Employees.Add(enew);
            db.SaveChanges();
            return enew;
        }

        public Employee DeleteEmploye(int eid)
        {
            Employee e = db.Employees.Find(eid);
            if(e!=null)
            {
                db.Employees.Remove(e);
                db.SaveChanges();
            }
            return e;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return db.Employees.Find(id);
        }

        public Employee UpdateEmployee(Employee echanges)
        {
            var employee = db.Employees.Attach(echanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return echanges;
        }
    }
}
