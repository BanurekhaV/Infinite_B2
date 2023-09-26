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
            //Singleton trainer = Singleton.GetInstance();
            //trainer.Print("From the Trainer..");

            //Singleton trainee = Singleton.GetInstance();
            //trainee.Print("From the Trainees...");

            //it creates a single object reference and returns the reference 
            //to the 2 objects viz trainer and trainee

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
        }
    }
}
