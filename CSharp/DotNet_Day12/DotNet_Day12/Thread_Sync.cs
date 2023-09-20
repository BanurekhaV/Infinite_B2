using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DotNet_Day12
{
    class LockingThread
    {
        public void LockFunction()
        {
            lock (this)  
            {
                for(int i=0; i<=5; i++)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("The value od i : {0}", i);
                }
            }
        }
    }
    class Thread_Sync
    {
        static void Main()
        {
            //Thread t1 = new Thread(Function1);
            //t1.Start();
            //Thread t2 = new Thread(Function2);
            //t2.Start();
            //t1.Join();
            //t2.Join();

            //thread locks as synchronization
            LockingThread lt = new LockingThread();
            Console.WriteLine("------Using Locks in Threads----");
            Thread td1 = new Thread(new ThreadStart(lt.LockFunction));
            Thread td2 = new Thread(lt.LockFunction);
            td1.Start();
            td2.Start();
            Console.Read();
        }
               
        public static void Function1(object obj1)
        {
            Console.WriteLine("Object 1");
        }

        public static void Function2(object obj2)
        {
            Console.WriteLine("Object 2");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2 Called : " + i);
                if (i == 3)
                {
                    Console.WriteLine("Called for performing some Data Operations...");
                    Thread.Sleep(10000); // putting the thread to sleep for 10 seconds
                    Console.WriteLine("Operation Completed..");
                }

            }
        }
    }

}
