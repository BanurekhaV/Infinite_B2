using System;

namespace Day3_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Program.CallByValue_Method(i);  //calling a static method
            Console.WriteLine("I is {0}",i);
            Console.WriteLine("----------");
            Program prog = new Program();
            prog.CallByRef_Method(ref i); //calling a non static method
            Console.WriteLine("I is {0}", i);
            Console.WriteLine("-----------");
            int total = 0;
            int prod = 0;
            int diff = 0;
            int div = Program.Calculate_Method(10, 15, out total, out  prod, out diff);
            Console.WriteLine($"Sum is {total}, Product is {prod}, Difference is {diff} and the Division is {div}");
            Console.Read();
        }

        public static void CallByValue_Method(int j)
        {
            j = 100;
            Console.WriteLine("J is {0}",j);
        }

        public void CallByRef_Method(ref int j) 
        {
            j = 100;
            Console.WriteLine("J is {0}", j);
        }

        public static int Calculate_Method(int a, int b,  out int sum, out int product, out int difference)
        {           
            sum = a + b;
            product = a * b;
            difference = a - b;
            return a / b;
        }
    }
}
