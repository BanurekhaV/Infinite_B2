using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day4
{
    class Array_Eg
    {
        public void SingleDimensionArray()
        {
            int[] arr = new int[5] { 6, 23, 1, 45, 12 };
            Console.WriteLine("The length is{0}", arr.Length);
            System.Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(arr.Rank);
        }

        public void TwoDimensionArray()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine(myarray[1, 1]); // display a particular index value of 2 dimesion
            //1st loop to iterate thru the row values

            for (int i = 0; i < 2; i++)
            {
                //loop 2 to iterate the column values
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(myarray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void JaggedArray()
        {
            //1. decl jagged array of 2 rows
            int[][] myjaggedarray = new int[2][];

            //let us now set the size for each row
            myjaggedarray[0] = new int[3];
            myjaggedarray[1] = new int[2];
            
            //2. initialize the jagged array
            myjaggedarray[0][0] = 2;
            myjaggedarray[0][1] = 4;
            myjaggedarray[0][2] = 6;

            myjaggedarray[1][0] = 1;
            myjaggedarray[1][1] = 3;

            //example to initialize the jagged array in a different way

            int[][] jagg2 = {
                new int[] {5,10,15,20},
                new int[]{25,30},
                new int[]{35,40,45}
            };

            //we need 2 loops to iterate
            //outer loop
            for(int i=0;i<jagg2.Length;i++)
            {
                Console.WriteLine("Number of Elements at Row :" + i + "is " + " " + jagg2[i].Length);
                //inner loop
                for(int j=0; j < jagg2[i].Length;j++)
                {
                    Console.Write(jagg2[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
        class Program
        {
            static void Main(string[] args)
            {
            Array_Eg aeg = new Array_Eg();
            //aeg.SingleDimensionArray();
            //Console.WriteLine("+++++++++++");
            //aeg.TwoDimensionArray();
            // aeg.JaggedArray();
            StringsEg.StringOps();
             Console.Read();
            }
        }
    
}
