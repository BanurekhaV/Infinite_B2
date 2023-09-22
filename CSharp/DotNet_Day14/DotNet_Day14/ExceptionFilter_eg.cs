using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day14
{
    class ExceptionFilter_eg
    {
        static void Main()
        {
            try
            {
                int x = 10, y = 0;
                Console.WriteLine(x/y);
                int[] a = new int[5];
                a[10] = 10; 
            }

            catch (Exception e) when (e.GetType().ToString() == "System.DivideByZeroException")
            {
                DoSomeOtherFunction();
            }
            catch (Exception e) when (e.GetType().ToString() == "System.IndexOutOfRangeException")
            {
                Console.WriteLine("Hello I am an exception Filter..");
            }
            Console.Read();
        }
        static void DoSomeOtherFunction()
        {
            Console.WriteLine("Stared a new Task...");            
        }
    }
}
