using System;
using DotNet_Day5;

namespace DotNet_Day5_Prj2
{
    class Program2 : AccessSpecifier_Eg
    {
        static void Main(string[] args)
        {
            AccessSpecifier_Eg ag2 = new AccessSpecifier_Eg();
            ag2.SName = "Project 2";
          //  Console.WriteLine(ag2.SName);
            
            Program2 p2 = new Program2();
            p2.Total = 499;
            
            p2.pic = 'D';

            Console.WriteLine("-------ReadOnly and Constant---------");
            ReadOnlynConstant_Eg roc = new ReadOnlynConstant_Eg(100, 200);
            ReadOnlynConstant_Eg roc2 = new ReadOnlynConstant_Eg(25);
            Console.ReadLine();
        }
    }

    
}
