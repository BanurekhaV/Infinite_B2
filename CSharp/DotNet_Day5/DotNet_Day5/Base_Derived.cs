using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day5
{
    class FirstClass 
    {
        public FirstClass()
        {
            Console.WriteLine("This Is First");
        }
    }

    class SecondClass : FirstClass
    {
        public SecondClass()
        {
            Console.WriteLine("This is Second");
        }
    }

    class ThirdClass : SecondClass
    {
        public ThirdClass()
        {
            Console.WriteLine("ThirdClass");
        }
    }
    class Base_Derived
    {
        static void Main()
        {
            ThirdClass tc = new ThirdClass();
            Console.Read();
        }
    }
}
