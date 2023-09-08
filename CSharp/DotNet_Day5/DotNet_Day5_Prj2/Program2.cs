using System;
using DotNet_Day5;

namespace DotNet_Day5_Prj2
{
    class Program2 
    {
        static void Main(string[] args)
        {
            AccessSpecifier_Eg ag2 = new AccessSpecifier_Eg();
            ag2.SName = "Project 2";
            Console.WriteLine(ag2.SName);
            Console.ReadLine();
        }
    }
}
