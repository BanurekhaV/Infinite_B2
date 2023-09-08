using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day5
{
    public class AccessSpecifier_Eg
    {
        private int Id;
        public string SName;
        internal float Marks;

        public void acceptfn()
        {
            Id = 1;
            SName = "Banurekha";
            Marks = 80.5f;
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            AccessSpecifier_Eg ag = new AccessSpecifier_Eg();
            ag.SName = "Infinite";
            Console.WriteLine(ag.SName);
            ag.Marks = 78;            
            Console.Read();
        }
    }
}
