using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day10
{
    //generic delegate decl.

    public delegate T Calculate<T>(T arg);
    class GenericDelegates
    {
        public static void Transform<T>(T[] values, Calculate<T> c)
        {
            //run a loop for the number of array size
            for(int i=0; i<values.Length;i++)
            {
                //accept values into the array, by invoking the delegate
                values[i] = c(values[i]); //invoking the delegate
            }
        }
    }

    class TestGenericDelegates
    {
        static void Main()
        {
            int[] v = new int[] { 4, 5, 6 };
            GenericDelegates.Transform(v, square);

            foreach(var item in v)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("With Float Values");
            float[] f = new float[] { 4.4f, 5.5f, 6.6f };

            GenericDelegates.Transform(f, square);

            foreach (var item1 in f)
            {
                Console.Write(item1 + " ");
            }
            Console.Read();
        }

        //overloaded square function
        static int square(int x)
        {
            return x * x;
        }

        static float square(float f)
        {
            return f * f;
        }
    }
}
