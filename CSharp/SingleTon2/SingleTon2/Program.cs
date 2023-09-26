using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTonPattern;

namespace SingleTon2
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton training = Singleton.GetInstance();
            training.Print("this is the Training..");
            Console.Read();

        }
    }
}
