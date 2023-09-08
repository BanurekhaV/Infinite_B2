using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day5
{
    class Student
    {
        private string RollNo;
        private string Name;
        private string Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll No:");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Class");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name is " + " "+ Name);
            Console.WriteLine("Roll No is " + " " + RollNo);
            Console.WriteLine("Class is " + " " + Class);
        }

    }

    class Marks : Student
    {
        protected int[] m = new int[5];

        public void GetMarks()
        {
            for(int i=0; i<m.Length;i++)
            {
                Console.Write("Enter Subject {0} Marks :", i+1);
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine("Marks in Subject {0} is : {1}", i+1,m[i]);
            }

        }
    }

    class Result : Marks
    {
        int TotalMarks = 0;

        public void GetResult()
        {
            for (int i = 0; i < m.Length; i++)
            {
                TotalMarks = TotalMarks + m[i];
            }
            Console.WriteLine("total Marks  " + TotalMarks);
        }

        public void DisplayResult()
        {
            Console.WriteLine("=======Results========");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks Scored :" + " " + TotalMarks);           
        }
    }
    class MultiLevel_Inheritance
    {
    }
}
