using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day4
{
    struct student
    {
        public int marks1;
        public int marks2;
    }
    class Struct_Eg
    {
        public static void structnclass()
        {
           // student s1; //or
            student s1 = new student();
            s1.marks1 = 50;
            s1.marks2 = 70;
            Console.WriteLine(s1.marks1 + s1.marks2);

            student s2 = new student();
            s2 = s1;
            Console.WriteLine(s2.marks1+s2.marks2);

            s1.marks1 = 80;
            s1.marks2 = 80;
            Console.WriteLine("-----after changes----");
            Console.WriteLine(s1.marks1 + s1.marks2);
            Console.WriteLine(s2.marks1 + s2.marks2);
        }
    }

    enum cities {Agra,Bangalore,Chennai,Delhi,Hyderabad,Kolkatta,Mumbai}
    class Enum_Eg
    {
        enum Days {Mon=1,Tue,Wed,Thur,Fri,Sat,Sun=0};   
        
        public static void EnumOps()
        {
            foreach(int x in Enum.GetValues(typeof(cities)))
            {
                if(x==1)
                   // Console.WriteLine();
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + "Is a Garden City");
                else if(x==2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + "Is a City of Temple");
                else if(x==6)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + "Is a Financial City");
            }

            foreach(string s in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(s);
            }
        }

    }
}
