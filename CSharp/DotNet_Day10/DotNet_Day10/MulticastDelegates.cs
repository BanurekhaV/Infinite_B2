using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day10
{
    public delegate void MultiCastDelegate();
    class MulticastDelegates
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3");
        }

        public static void Main()
        {
            // one way to work with multicast delegates
            MultiCastDelegate md1, md2, md3, md4;
            md1 = new MultiCastDelegate(Method1);
            md2 = new MultiCastDelegate(Method2);
            md3 = new MultiCastDelegate(Method3);
            md4 = md1 + md2 + md3;
            md4();
            Console.WriteLine("===========");
            md4 = md1 - md2 + md3;
            md4();

            //2nd approach to multicast delegates
            Console.WriteLine("**********");
            MultiCastDelegate m = new MultiCastDelegate(Method1);
            m += Method2;
            m += Method3;
            m();
            m -= Method1; // m= m-Method1;
            m();
            Console.ReadLine();
        }
    }
}
