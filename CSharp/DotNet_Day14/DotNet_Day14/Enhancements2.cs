using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day14
{
    public class InfiniteEmployee
    {
        public long Id { get; set; }
        public string EName { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
    class Enhancements2
    {
        static void Main()
        {
            int a = 10, b = 5;
            int sum = Sum(a, b);
            int difference = Difference(a, b);
           // Console.WriteLine($"The Sum of {a} and {b} is {sum}");
            Console.WriteLine($"The difference of {a} and {b} is {difference}");
            Console.WriteLine(Difference(20,5));
            //we are writing Sum() and Difference() as Local functions inside the Main Function()
            int Sum(int x, int y)
            {
                return x + y;
            }

            int Difference(int x, int y)
            {
                return x - y;
            }

            Console.WriteLine(Sum(5,5));
            Console.WriteLine("--------------------");
            InfiniteEmployee iemp = new InfiniteEmployee()
            {
                Id = 1001,
                EName = "Prachi",
                Gender = "Female",
                Salary = 35000,
                Department = "Testing"
            };
            Boolean IsInserted = AddEmployee(iemp);
            
            Console.WriteLine("Is Employee with Id 1001 inserted :?{0}", IsInserted);
            
            InfiniteEmployee iemp1 = new InfiniteEmployee()
            {
                Id = 1002,
                EName = "Gowtham",
                Salary = 35000,
                Department = "Testing"
            };

            IsInserted = AddEmployee(iemp1);
            Console.WriteLine("Is Employee with Id 1002 inserted :?{0}", IsInserted);
            Console.Read();
        }

        //parent function

        public static bool AddEmployee(InfiniteEmployee e)
        {
            //var validationResult = IsRequestValid();
            //if(validationResult.isValid==false)
            //{
            //    Console.WriteLine($"{nameof(validationResult.errorMessage)} :{validationResult.errorMessage}"); 

            //}
            return true;            
        }
    }
}
