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
        protected int Total;
        internal protected char pic;

        public void acceptfn()
        {
            Id = 1;
            SName = "Banurekha";
            Marks = 80.5f;
            Total = 485;
            pic = 'A';
        }
    }
    class Program : AccessSpecifier_Eg
    {
        static void Main(string[] args)
        {
            //AccessSpecifier_Eg ag = new AccessSpecifier_Eg();
            //ag.SName = "Infinite";
            //Console.WriteLine(ag.SName);
            //ag.Marks = 78;
            //ag.pic = 'B';
            //Program p = new Program();
            //p.Total = 490;
            //p.pic = 'C';
            Console.WriteLine("-----Multi Level Inheritance-----");
            Result result = new Result();
            result.GetData();
            result.GetMarks();
            result.GetResult();
            result.DisplayResult();
            Console.Read();
        }
    }

    class Second : AccessSpecifier_Eg
    {
        public void Function1()
        {
            AccessSpecifier_Eg ag3 = new AccessSpecifier_Eg();
            ag3.pic = 'E';
           
            Second second = new Second();
            second.pic = 'F';

        }
    }
}
