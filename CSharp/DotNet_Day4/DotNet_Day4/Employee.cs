using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day4
{
    class Employee
    {
        int EmpId;
        string EmpName;
        DateTime DOJ;
        Double Salary;

        public Employee()
        {
            Console.WriteLine("Hello from Employee");
        }

        public Employee(int empid, double salary)
        {
            EmpId = empid;
            Salary = salary;
        }

        public Employee(int EmpId, string EmpName, DateTime DOJ, double sal)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.DOJ = DOJ;
            Salary = sal;            
        }
        public void Accept()
        {
            Console.WriteLine("Enter Employee ID,Name,DOJ and Salary :");
            EmpId = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            DOJ = Convert.ToDateTime(Console.ReadLine());
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowDetails()
        {
            Console.WriteLine("Employee Details .........");
            Console.WriteLine($"Employee ID is :{EmpId} Name is { EmpName}, Date of Joining is {DOJ} " +
                $"and Salary Earned is {Salary}"
                );
        }

    }
}
