using System;
using static System.Console;

namespace Day2_DotNet
{
    class ClassnInstance_Eg
    {
        public static void Main()
        {
            //creating object of the class
            ClassnInstance_Eg cobj = new ClassnInstance_Eg();
            ClassnInstance_Eg cobj2 = new ClassnInstance_Eg();
            Console.WriteLine(cobj.Add(5, 7)); // invoking an instance method
            Console.WriteLine(cobj2.Add(10, 20));
            staticEg.evenNos(4);  //invoking a class/static method that is in another class
            oddNos(6); //invoking a class/static method that is within the same class
             Read();            
        }

        public int Add(int x, int y) // instance functions/methods
        {
            return x + y;
        }

        public static void oddNos(int x)
        {
            if(x%2!=0)
                Console.WriteLine("Number is Odd");
            else
                Console.WriteLine("Number is Even");
        }
    }

    class staticEg
    {
        public static void evenNos(int num) // static functions are known as class functions/methods
        {
            if (num % 2 == 0)
                Console.WriteLine("Number is an even Number");
            else
                Console.WriteLine("Number is an Odd Number");
        }
    }
}
