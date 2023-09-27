using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBAL ebal = new EmployeeBAL(new EmployeeDAL());
            List<Employee> emplist = ebal.GetAllEmployees();

            foreach(Employee e in emplist)
            {
                Console.WriteLine($"ID ={e.ID}, Name = {e.Name} and Department = {e.Department}");
            }
            Console.Read();
        }
    }
}
