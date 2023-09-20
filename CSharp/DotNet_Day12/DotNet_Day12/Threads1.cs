using System;
using System.Threading;

namespace DotNet_Day12
{
    class Threads1
    {
        static void Main()
        {
            //Thread t = Thread.CurrentThread;
            //Console.WriteLine("Current executing Thread : {0}", t.Name);
            ////by default thtreads do not have any names
            ////we may give a name
            //t.Name = "Main Thread";
            //Console.WriteLine("Current executing Thread : {0}", t.Name);

            //drawback of a single threaded program
            //Method1();
            //Method2();
            //Method3();

            //to overcome the above problem, let us use multithreads

            Console.WriteLine("Main Thread Started...");
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };

            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };

            //the above created threads have to be started
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ended..");
            Console.Read();
        }

        static void Method1()
        {
            for(int i= 0; i<=5; i++)
            {
                Console.WriteLine("Method 1 Called : " + i);
            }
        }
        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2 Called : " + i);
                if(i==3)
                {
                    Console.WriteLine("Called for performing some Data Operations...");
                    Thread.Sleep(10000); // putting the thread to sleep for 10 seconds
                    Console.WriteLine("Operation Completed..");
                }

            }
        }
        static void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 3 Called : " + i);
            }
        }
    }

    
}
