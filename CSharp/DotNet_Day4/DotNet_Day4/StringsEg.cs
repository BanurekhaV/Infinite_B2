using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day4
{
    class StringsEg
    {
        public static void StringOps()
        {
            string s = "Hello";
            Console.WriteLine("First Time S {0}",s.GetHashCode());
            s = "Hello World";
            Console.WriteLine("Second Time S {0}",s.GetHashCode());

            string s1 = "CSharp";
            Console.WriteLine("S1 {0}",s1.GetHashCode());

            string s2 = s1;
            Console.WriteLine("s2 {0}",s2.GetHashCode());

            string s3 = "Hello"; // both address/ref and data are taken from the pool and
                                 // assigned to s3
            Console.WriteLine("s3  reference is same as first s {0}",s3.GetHashCode());

            Console.WriteLine(s + " "+ s1 + " " + " "+s2);

            //String Builder - mutable strings
            StringBuilder sb = new StringBuilder("Hello String");
            Console.WriteLine("sb's hash code is {0}", sb.GetHashCode());
            sb.Append("Builder");
            Console.WriteLine("sb's hash code after changes is {0}", sb.GetHashCode());
        }
    }
}
