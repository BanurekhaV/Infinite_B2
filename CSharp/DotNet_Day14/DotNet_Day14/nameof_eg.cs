using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day14
{
    class nameof_eg
    {
        int[] arr = new int[5];
        static void Main()
        {
            nameof_eg noe = new nameof_eg();
            try
            {
                noe.Show(noe.arr);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The name of the method is : "+ nameof(noe.Show));
            }
            Console.Read();
        }

        int Show(int[] a)
        {
            a[5] = 12;
            return a[5];
        }
    }
}
