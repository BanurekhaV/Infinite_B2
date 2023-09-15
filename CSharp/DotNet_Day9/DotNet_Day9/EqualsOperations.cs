using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day9
{
    class EqualsOperations
    {
        static void Main()
        {
            //reference equals with string literals
            string s1 = "a";
            // string s2 = "a"; returns true
            string s2=s1; // true
            //string s2 = new string('h', 'i');  false
           // string s2 = "b";  //returns false
            //Console.WriteLine(object.ReferenceEquals(s1,s2));
            StringBuilder sb1 = new StringBuilder();
            // StringBuilder sb2 = new StringBuilder();
            StringBuilder sb2 = sb1;
            Console.WriteLine(object.ReferenceEquals(sb1,sb2));
            Console.WriteLine("----------------");
            Console.WriteLine(s1.Equals(s2));

            //compareTo with value types
            Console.WriteLine("CompareTo with Value Types");
            const int x= 5;
            const int y = 6;
            const int z = 5;

            Console.WriteLine(x.CompareTo(y)); //returns -1 (first numeber is small)
            Console.WriteLine(x.CompareTo(z)); //returns 0 (both are same)
            Console.WriteLine(y.CompareTo(z)); //returns 1 (first is big)
                       
            Console.Read();
        }
    }
}
