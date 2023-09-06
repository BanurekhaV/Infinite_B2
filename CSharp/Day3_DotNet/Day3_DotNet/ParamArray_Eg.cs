using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_DotNet
{
    class ParamArray_Eg
    {
        public int AddElements(params int[] arr)
        {
           int sum = 0;
            foreach (int i in arr)
            {
                sum += i;  // sum = sum+i
            }

            return sum;
        } 
        
        public static void Params_Method(params int[] number)
        {
            Console.WriteLine("There are {0} number of elements in the Array",number.Length);
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }
        }
    }

    class TestParamArray
    {
        public static void Main()
        {
            ParamArray_Eg parameg = new ParamArray_Eg();
            int Total = parameg.AddElements(); //calling the function with zero arguments

            Console.WriteLine("The sum is :{0}",Total);
            Console.WriteLine("------------");
            Total = parameg.AddElements(2); //calling the function with 1 argument
            Console.WriteLine("The sum is :{0}", Total);
            Console.WriteLine("------------");
            Total = parameg.AddElements(2,4,6,8,10); //calling the function with many argument
            Console.WriteLine("The sum is :{0}", Total);
            Console.WriteLine("------------");
            Console.WriteLine("------------");
            ParamArray_Eg.Params_Method(); //0 argument

            int[] arr = new int[3];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;

            ParamArray_Eg.Params_Method(arr); //passing an array

            ParamArray_Eg.Params_Method(1, 2, 3, 4, 5, 6); //comma separated value

          //  add(5, 15.56f, 34.5,45.6,78.9);
            
            Console.Read();
        }

       /* public static void add(int x, float f, params double[] d)
        {
            Console.WriteLine("{0},{1}",x,f);

            foreach( double dbl in d)
            {
                Console.WriteLine(dbl);
            }
        }*/
    }
}
