using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day11
{
    class Program
    {
        delegate void Print(int v);
        delegate int Arithmetic(int x, int y);
        static void Main(string[] args)
        {
            int i = 100;
            Print p = delegate (int x) //delegate calling an anonymous method
            {
                x += i;
                Console.WriteLine("We are inside Anonymous Method {0}", x) ; 
            };
            p(10);

            //eg 2 anonymous method

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] evennos = Array.FindAll(numbers, delegate (int num)
                {
                    return num % 2 == 0;
                });
            Console.WriteLine("-----Even nos------");
            foreach (int item in evennos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------Predicate --------");
            Predicate<string> chkupper = delegate (string s)
            {
                return s.Equals(s.ToUpper());
            };
            bool res = chkupper("HELLO WORlD");
            Console.WriteLine(res);
            //DoOperation(10, 2, Multiply);
            //DoOperation(10, 2, Divide);

            Console.WriteLine("------Function Delegate -----");
            Func<int> getRnumber = delegate ()
            {
                Random r = new Random();

                return r.Next(1, 100);
            };
            int rand = getRnumber();
            Console.WriteLine(rand);

            Console.WriteLine("-----Action Delegate-----");
            Action<int> ExampleActionDelegate = delegate (int s)
               {
                   Console.WriteLine(s);
               };
            ExampleActionDelegate(25);


            Console.Read();
        }

        static void DoOperation(int x, int y, Arithmetic adel)
        {
            int z = adel(x, y); //invoking the delegate 
            Console.WriteLine(z);
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }

        
    }
}
