using System;

using System.Threading;

namespace DotNet_Day12
{
    class ThreadStates
    {
        static void Main()
        {
            try
            {
                //unstarted state
                Thread t1 = new Thread(Somemethod);
                Console.WriteLine($"Before start , IsAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");
                //runnable
                t1.Start();
                Console.WriteLine($"Before start , IsAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");
                //not runnable

                t1.Suspend();
                Console.WriteLine($"Before start , IsAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");

                //resume to runnable state
                t1.Resume();
                Console.WriteLine($"Before start , IsAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");
                //terminate the thtread
                t1.Abort();
                Console.WriteLine($"Before start , IsAlive : {t1.IsAlive}, Thread State : {t1.ThreadState}");
                t1.Start();
            }
            catch(Exception e)
            {
                Console.WriteLine("Some Problem..");
            }
            Console.Read();
        }

        public static void Somemethod()
        {
              for(int i=0; i<3; i++)
            {
                Thread.Sleep(2000);
            }
            Console.WriteLine("Method completed...");
        }
    }
}

