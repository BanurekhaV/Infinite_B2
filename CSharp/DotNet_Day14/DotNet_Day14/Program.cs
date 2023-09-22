using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day14
{
    public class Employee
    {
        public string EId { get; } = "100234";  //setting a value at the time of declaration of a read only property
        public Double Salary { get; set; } = 45000;
        public string EmpName { get; private set; }
        public string Dept { get; protected set; } = "Sales";

        public Employee()
        {
            EId = "1234";  //we can override a read only property only in the constructor
        }
        public void Empsetting()
        {
            
            EmpName = "Meghana";
            Dept = "HR";
        }
        
    }
    class Program :Employee
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Program p = new Program();
            p.Dept = "Finance";
            e.Salary = 50000;
            e.Empsetting();
            Console.WriteLine("{0},  {1},  {2},  {3}, Childs Dept {4}", e.EId, e.EmpName, e.Dept, e.Salary,p.Dept);

            //before C# 6.0
            Dictionary<string, string> emp = new Dictionary<string, string>()
            {
                {"E001", "John" },
                {"E004" , "Rahim"},
                {"E005" , "Rahul" }
            };
            //with C# 6.0
            Dictionary<string, string> emp1 = new Dictionary<string, string>()
            {
                ["E001"] = "John" ,
                ["E004"] = "Rahim",
                ["E005"] = "Rahul" ,
            };

            foreach(KeyValuePair<string,string> kvp in emp1)
            {
                Console.Write(kvp.Key);
                Console.Write(kvp.Value);
                Console.WriteLine();
            }

            //throws 
            var v = Divide(10, 2);
            Console.WriteLine(v);
            Console.WriteLine("-----------------");
            IEnumerable<string> rlist = GetFruits();
            foreach(var i in rlist)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }

        public static int Divide(int a, int b)
        {
            return b != 0 ? a : throw new DivideByZeroException();
        }

        //iterators with yield statement
        public static IEnumerable<string>GetFruits()
        {
            List<string> fruitlist = new List<string>()
            {
                "Guava","Banana","Apple","Orange","Strawberry"
            };

            //returning the element after every iteration
            foreach(var items in fruitlist)
            {
                yield return items;

            }
        }
    }
}
