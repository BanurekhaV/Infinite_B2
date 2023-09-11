using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day6
{
    class function_overloading
    {                                   //10, 12
        public void swap(int number1, int number2)
        {
            number1 = number1 + number2;  //22, 12
            number2 = number1 - number2;   //22-12= 10, 22
            number1 = number1 - number2;   //22-10 = 12, 10 

            //or
            //int temp = number1;
            //number1 = number2;
            //number2 = temp;
            Console.WriteLine("After Swapping 2 nos. {0} and {1}", number1,number2);
        }

        public void swap(char character1, char character2)
        {
            char temp = ' ';
            temp = character1;
            character1 = character2;
            character2 = temp;

            Console.WriteLine("After Swapping 2 Characters. {0} and {1}", character1, character2);
        }

        static void Main()
        {
            function_overloading fo = new function_overloading();
            function_overloading fo1 = new function_overloading();
            fo.swap('Z', 'A');
            fo.swap(100, 5);

            int x=8, y=8;
            int z = x + y;
            Console.WriteLine(z);                    
            Console.Read();
        }
    }
    
}
