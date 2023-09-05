using System;


namespace Day2_DotNet
{
   
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your First Name :");
            string fname=Console.ReadLine();
            //Console.WriteLine("Your Name is " + fname); // Concatenation
            //Console.WriteLine("Your Name is {0}", fname);//placeholder
            //Multiple Placeholder example to display data
            Console.WriteLine("Enter your Last Name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Your First Name is :{0} and your Last name is :{1}",fname,lname);
            //string interpolation to display data
            Console.WriteLine($"Your FirstName is {fname} and your lastName is {lname}");
            Myclass.MyFunction();
          
          //  func2();
            Console.Read();
        }
        
        static void func2()
        {
            Console.WriteLine("This func2");
            Console.WriteLine("Enter your Age :");
            int age = int.Parse(Console.ReadLine());
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You are {age} years old");
            Console.WriteLine("Min Value = {0}",int.MinValue);
            Console.WriteLine("Min Value = {0}", int.MaxValue);
        }
    }

    class Myclass
    {
        public static void MyFunction()
        {
            Console.WriteLine("We are discussing Main Function");
            int num = 30;
            bool b;
           /* if(num==10)
            {
                b = true;
            }
            else
            {
                b = false; 
            }
            Console.WriteLine("Number == 10 is {0}", b); */

            //the above lines of code can be replaced with a ternary operator as below
            b = num == 10 ? true : false;

            Console.WriteLine("Number == 10 is {0}", b);
        }
    }
}
