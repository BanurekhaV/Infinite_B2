using System;

namespace DotNet_Day10
{
    public delegate void EmployeeHandler(string s);  //declaration of delegate with a signature
    delegate int NumberChanger(int n);
    class Employee
    {
        public static void AcceptEmployee(string s)
        {
            Console.WriteLine("Hello " + " " + s);
        }

        public void DisplayEmployee(string msg)
        {
            Console.WriteLine(msg);
        }

        public void JustLikeThat()
        {
            Console.WriteLine("Simple Function");
        }
    }

    class Delegate2Testing
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            //instantiating a delegate object and passing the reference of a function
            EmployeeHandler eh1 = new EmployeeHandler(Employee.AcceptEmployee);
            EmployeeHandler eh2 = new EmployeeHandler(e.DisplayEmployee);
            //1. to invoke the delegate
            eh1("Shubangi");
            //2. 
            eh2.Invoke("Radha");

            Console.WriteLine("----Example 2-----");
            NumberChanger nc1 = new NumberChanger(Delegate2Testing.AddNum);
            NumberChanger nc2 = new NumberChanger(Delegate2Testing.MultiplyNum);

            nc1(25);
            Console.WriteLine("Current Values of Num :{0}", Delegate2Testing.getNum());

            nc2(5);
            Console.WriteLine("Current Values of Num :{0}", Delegate2Testing.getNum());
            Console.Read();
        }
    }
}
