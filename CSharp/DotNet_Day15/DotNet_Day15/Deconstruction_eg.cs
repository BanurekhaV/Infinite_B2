using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day15
{
    class Deconstruction_eg
    {
        // 1st way of deconstruction / splitting up of a tuple object
        //static void Main()
        //{
        //    var EmpDetails = GetEmployeeDetails(100);
        //    var name = EmpDetails.Item1;
        //    var sal = EmpDetails.Item2;
        //    var gen = EmpDetails.Item3;
        //    var dept = EmpDetails.Item4;

        //    Console.WriteLine("----Employee Details -----");
        //    Console.WriteLine($"Name : {name}, Salary :{sal}, Gender : {gen}, Department : {dept}");
        //    Console.Read();
        //}

        //2nd way of deconstruction

        //static void Main()
        //{
        //    (string name, double sal, string gen, string dept) = GetEmployeeDetails(100);
        //    Console.WriteLine($"Name : {name}, Salary :{sal}, Gender : {gen}, Department : {dept}");
        //    Console.Read();
        //}

        //3rd way of splitting

        //static void Main()
        //{
        //    var (name, sal, gen, dept) = GetEmployeeDetails(100);
        //    Console.WriteLine($"Name : {name}, Salary :{sal}, Gender : {gen}, Department : {dept}");
        //    Console.Read();
        //}

        //4th way of splitting

        //declare variables
        static void Main()
        {
            string name, gen, dept;
            double sal;
            (name, sal, gen, dept) = GetEmployeeDetails(100);

            Console.WriteLine($"Name : {name}, Salary :{sal}, Gender : {gen}, Department : {dept}");
            sal += sal * 0.1;
            Console.WriteLine("Updates Sal {0}",sal);
            Console.Read();
        }
        public static(string,double,string,string)GetEmployeeDetails(int id)
        {
            //in real prog, we will get the data from the database whose ever id matches
            // so let us hard code 
            string Ename = "Hansika";
            double Salary = 2500;
            string Gender = "Female";
            string Department = "IT";
            return (Ename, Salary, Gender, Department);
        }
    }
}
