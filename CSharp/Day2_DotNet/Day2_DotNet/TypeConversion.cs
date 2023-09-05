using System;

namespace Day2_DotNet
{
    class TypeConversion
    {
        static void Main()
        {
            Console.WriteLine("Understanding Type Conversions..");
            int i = 100;
            float f = i;   //implicit conversion
            Console.WriteLine(f);
            i = (int)f;  //explicit type casting 
            Console.WriteLine(i);
           
            float f2 = 12434545678966.44356f;
           //  i=Convert.ToInt32(f2);  //explicit typecasting using conversion function of C#
            i = (int)f2;

            //try increasing the value of the float variable and observe the below:
            
            //conversion function is throwing an exception, where as typecasting

            // is showing the limitation
            Console.WriteLine(i);

            

            string str = "100";
            //i = int.Parse(str);
            //Console.WriteLine(i);

            //now lets use tryparse() to avoid exception unlike the above parse()
            //even if it fails to convert

            int result;
            bool success = int.TryParse(str, out result);

            if(success)
            {
                Console.WriteLine("The number is " + result);
            }
            else
                Console.WriteLine("Invalid Data");
            Console.WriteLine("-----------------");
            TypeConversion tc = new TypeConversion();
             tc.RefConversion();
            Nullable_eg();
            Console.Read();
        }

        public void RefConversion()
        {
            int i = 10; 
            object o;
            o = i;  //value type to reference type  -- boxing
            Console.WriteLine(o);
            float salary;
            Console.WriteLine("Enter Salary :");
          //  salary = float.Parse(Console.ReadLine());  //ref type to value type -- unboxing
            salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(salary);
            string s = "aaa";
            o = s;  // implicit casting between 2 reference types
            Console.WriteLine(o);
            Console.WriteLine(s);
        }

        static void Nullable_eg()
        {
            string s1 = null; // ref types can be assigned null
            int ? totaltickets = null; // value type being made nullable using ?
            int available_tickets;

            if (totaltickets == null)
            {
                available_tickets = 0;
            }
            else
                available_tickets = Convert.ToInt32(totaltickets);

            Console.WriteLine(available_tickets);

            //the above lines of code can be replaced with null coalescing operator ??
            available_tickets = totaltickets ?? 0;

            Console.WriteLine(available_tickets);

            //char ? c = 'a';
            //c = null;
        }
    }
}
