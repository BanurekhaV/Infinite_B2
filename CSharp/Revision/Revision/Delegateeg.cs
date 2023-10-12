using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public delegate void revisiondelegate(string s);    
    public delegate double delfunc1(int i, float f, double d);
    public delegate void delfunc2(int i, float f, double d);
    public delegate bool delfunclen(string s);
    class Delegateeg
    {
        public static void delegatehandler(string str)
        {
            Console.WriteLine("Hi :" + str);
        }

        //generic delgates need and usage
        public static double Addnumber1(int n1, float n2, double n3)
        {
            return n1 + n2 + n3;
        }

        public static void Addnumber2(int n1, float n2, double n3)
        {
            Console.Write("The sum of all inputs :");
            Console.Write(n1+n2+n3);
            Console.WriteLine();
        }

        public static bool CheckLength(string n)
        {
            if (n.Length > 5)
                return true;
            return false;
        }
    }
}
