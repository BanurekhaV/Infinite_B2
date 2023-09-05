using System;


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
           // evenNos(4);  //invoking a class/static method
                          ClassnInstance_Eg.evenNos(7);
            Console.Read();
            
        }

        public int Add(int x, int y) // instance functions/methods
        {
            return x + y;
        }

        public static void evenNos(int num) // static functions are known as class functions/methods
        {
            if(num%2==0)
                Console.WriteLine("Number is an even Number");
            else
                Console.WriteLine("Number is an Odd Number");
        }
    }
}
