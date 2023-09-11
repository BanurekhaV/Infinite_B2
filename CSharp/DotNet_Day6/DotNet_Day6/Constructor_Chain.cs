using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day6
{
    class Constructor_Chain
    {
       int Id;
        string Name;
        float Salary;

        public Constructor_Chain(int a, string n):this()
        {
            //Console.WriteLine("Constructor 1");
            Id = a;
            Name = n;
        }

        public Constructor_Chain()
        {
            Console.WriteLine(Id + " " + Name +  " "+Salary);
        }

        public Constructor_Chain(float f):this(10,"Arun Kumar")
        {
            //Console.WriteLine("Constructor 2");
            Salary = f;
        }

        public void ShowData()
        {
            Console.WriteLine($"{Id}, {Name}, {Salary}");
        }
    }
}
