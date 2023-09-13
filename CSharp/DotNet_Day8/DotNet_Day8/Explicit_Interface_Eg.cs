using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day8
{
    interface IOne
    {
         void Print();
    }
    interface ITwo
    {
        void Print();
    }
    class Explicit_Interface_Eg : IOne, ITwo
    {
        //explicit implementation of the interface method using the interface refernce
        // void IOne.Print()
        //{
        //    Console.WriteLine("IOnes Print Method..");
        //}

        //to make the above method default
        public void Print()
        {
            Console.WriteLine("IOnes Print Method..");
        }

        void ITwo.Print()
        {
            Console.WriteLine("ITwos Print Method ..");
        }

        static void Main()
        {
            // First Option to access explicit methods
            // by referencing the interface name
            Explicit_Interface_Eg Eig = new Explicit_Interface_Eg();
            
            ((IOne)Eig).Print(); // print() of IOne interface will be called
            ((ITwo)Eig).Print(); //print() of ITwo interface will be called

            //or the second option to access explicit methods

            Console.WriteLine("===============");
            IOne ione = new Explicit_Interface_Eg();
            ione.Print();
            ITwo itwo = new Explicit_Interface_Eg();
            itwo.Print();

            Console.WriteLine("-------Calling the Default Print()-------");
            Eig.Print();
            Console.Read();            
        }

        
    }
}
