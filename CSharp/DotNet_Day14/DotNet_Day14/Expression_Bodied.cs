using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day14
{
    class Expression_Bodied
    {
        public static bool IsEven(int num) => num % 2 == 0;
        void Method1(string s) => Console.WriteLine("The data is " + s);
        int Marks=89;
        public int Score
        {
            get { return Marks; }
        }

        //We can re write the properties with exp bodied member as
        public int Age => 28;

        //manual imple. of property using exp bodied 
        public string name
        {
            get => name;
            set => name = value;
        }
        static void Main()
        {
            int number = 3;
            if(IsEven(number))
            {
                Console.WriteLine("Number : {0} is even ", number);
            }
            else
            {
                Console.WriteLine("Number : {0} is odd", number);
            }
            Console.Read();
                
        }
    }
}
