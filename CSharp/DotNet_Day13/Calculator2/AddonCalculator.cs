using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDLL;

namespace Calculator2
{
    public static class AddonCalculator
    {
        public static int Subtract2Nos(this CalculatorClass cobj, int x, int y)
        {
            return x - y;
        }

        public static int Multiply2Nos(this CalculatorClass cobj, int x, int y)
        {
            return x * y;
        }
    }
}
