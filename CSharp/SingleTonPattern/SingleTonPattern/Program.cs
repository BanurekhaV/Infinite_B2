using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    //dependant class
    class Program
    {
        static void Main(string[] args)
        {
            //since we cannot instantiate the singleton class , we will call
            //the GetInstance method
            Singleton trainer = Singleton.GetInstance();
            trainer.Print("From the Trainer..");

            //now let us create another singleton object, and understand that
            // there is no second instance created, but only the same instance 
            //is returned 
            Singleton trainee = Singleton.GetInstance();
            trainee.Print("From the Trainees...");

            //violation of singleton pattern by deriving the dependency class
            Singleton.DerivedSingleton dsobj = new Singleton.DerivedSingleton();
            dsobj.Print("From the Derived...");
            Console.Read();

            /* static void Main()
    {
     // Let us now try to run the program in a multi threaded environment
            //by invoking the Parallel class method, which will create
            ////multiple threads to execute different functions
            /// thereby creating 2 objects of the singleton class
            /// which is against the principle of Single Ton Pattern


            Parallel.Invoke(
               () => PrintTrainer(),  // runs in one thread
               () => PrintTrainee());  // runs in another thread

            Console.Read();
        }
    static void PrintTrainer()
    {
      Singleton trainer = Singleton.GetInstance();
     trainer.Print("From the Trainer..");
    }

    static void PrintTrainee()
    {
        Singleton trainee = Singleton.GetInstance();
        trainee.Print("From the Trainees...");
    }*/

        }


    }
}

    