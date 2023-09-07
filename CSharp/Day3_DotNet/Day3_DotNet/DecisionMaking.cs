using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_DotNet
{
    class DecisionMaking
    {
        public void CheckGrade()
        {
            char grade;
            int Maths;
            Console.WriteLine("Enter your Grade:");
            grade = Convert.ToChar(Console.ReadLine());
           // Console.WriteLine("enter your Maths Score :");
           // Maths = Convert.ToInt32(Console.ReadLine());
            if (grade == 'O'||grade =='o') 
                Console.WriteLine("Outstanding");
            else if (grade == 'A'|| grade =='a')
                Console.WriteLine("Excellent");
            else if (grade == 'B' || grade =='b')
                Console.WriteLine("Very Good");
            else if (grade == 'C' || grade =='c')
                Console.WriteLine("Good");
            else if (grade == 'D' || grade =='d')
                Console.WriteLine("Can Improve");
            else
                Console.WriteLine("invalid Grade");
        }

        public void CheckGradeWithSwitch()
        {
            char grade; int maths;
            Console.WriteLine("Enter your Grade:");
            grade = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter maths score:");
            maths = Convert.ToInt32(Console.ReadLine());
            switch(grade)
            {
                case 'O' :
                case 'o' :  
                    Console.WriteLine("Outstanding");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }
    }

    class Loops
    {
        public void WhileLoop()
        {
            int i = 1;
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void ForLoop()
        {
            int tot = 0;
            for(int i=0; i<=5; i++)
            {
                if (i == 3)
                    // break;
                    continue;
                tot += i;
            }
            Console.WriteLine("Sum of all numbers {0}", tot);
        }
    }

    class TestDecision
    {
        static void Main()
        {
            DecisionMaking dm = new DecisionMaking();
            dm.CheckGrade();
            dm.CheckGradeWithSwitch();
            Console.WriteLine("*************");

            //Loops loops = new Loops();
            //loops.DoWhileLoop();
            //loops.WhileLoop();
            //loops.ForLoop();

            int[] data = new int[] { 76, 4, 12, 0, 3 };
            Console.WriteLine(data.Length);
            Console.WriteLine("-----Before Sort-------");
            foreach (int x in data)
            {
                Console.WriteLine(x);

            }
            Console.WriteLine("------After Sort -----");
            Array.Sort(data);

            string[] str = new string[2]{"hello", "world"};
            foreach (var x in str)
            {
                Console.WriteLine(x);

            }

            
            //Array.Reverse(data);

            //foreach (int x in data)
            //{
            //    Console.WriteLine(x);
            //}

            int x1;  //declaring a variable
            x1 = 7; // assing a value to the variable

            var v=7.8;
            Console.WriteLine(v);
            v = 'a';
            Console.WriteLine(v);
            v = 6;
            
            
            dynamic d;
            d = 'f';
            d = 3;
            d = "ASDFG";
            d= 7.6f;
            d = 4567.567;


            

            Console.Read();
        }
    }
}
