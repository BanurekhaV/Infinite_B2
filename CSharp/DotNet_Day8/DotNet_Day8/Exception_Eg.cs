using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day8
{
    class Exception_Eg
    {
        static void Main()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("enter 2 nos:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                int[] arr = { 1, 2, 3, 4 };
                Console.WriteLine(arr[6]);
                Console.WriteLine(c);
               // Console.Read();
            }
            
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);// " " + fe.StackTrace);
                Console.WriteLine("Enter only numbers..");
              //  Console.Read();
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
                Console.WriteLine("You cannot divide a number by Zero");
               // Console.Read();
            }
            catch(IndexOutOfRangeException ie)
            {
                Console.WriteLine("You are trying to access beyond the range");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong ...");
                //  Console.Read();
            }

            finally
            {
                Console.WriteLine("Reached Finally ..");
                Console.Read();
            }

        }
    }
}
