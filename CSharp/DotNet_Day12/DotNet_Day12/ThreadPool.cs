using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DotNet_Day12
{
    class ThreadPool
    {
        static void Main()
        {
            // No Thread Pools
            //for(int i=0; i<10;i++)
            //{
            //    Thread thread = new Thread(Method1)
            //    {
            //        Name = "Thread" + i
            //    };
            //    thread.Start();
            //}

            //with Thread Pool
            for(int i=0; i<10; i++)
            {
               System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback(Method1));
            }
           
            Console.Read();
        }

        public static void Method1(object o)
        {
            Thread thread = Thread.CurrentThread;
            string msg = $"Background : {thread.IsBackground}, Thread Pool : {thread.IsThreadPoolThread}," +
                $"Thread ID : {thread.ManagedThreadId}";
            Console.WriteLine(msg);
        }
    }
}
