using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day8
{
    class Checked_UnChecked
    {
        static void Main()
        {
            int a = 2147483647;
            int b = 1045675890;
            int c = unchecked(a + b);
            Console.WriteLine(c);
            Console.Read();
        }
    }
}
