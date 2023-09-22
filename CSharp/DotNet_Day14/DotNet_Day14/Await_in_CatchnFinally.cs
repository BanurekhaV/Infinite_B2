using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DotNet_Day14
{
   public class FileRead
    {
        public async void fileReaderOption()
        {
            try
            {
                StreamReader sr = File.OpenText(@"C:\Banu\Infinite\B2\Git Basic.txt");
                Console.WriteLine($"The First Line of the file is : {sr.ReadLine()}");
                sr.Close();
            }
            catch
            {
                await FileNotFound();
            }
            finally { await ExitProgram();
                Console.WriteLine("All objects released");
            }
        }

        async Task FileNotFound()
        {
            Console.WriteLine("The Requested file is not found.. please check the name");
        }

        async Task ExitProgram()
        {
            Console.WriteLine("\n Press any Key to Exit");
        }
    }
    class Await_in_CatchnFinally
    {
        static void Main()
        {
            //addAsyncFunc();
            FileRead fr = new FileRead();
            Console.WriteLine("Object Created ..");
            fr.fileReaderOption();
            Console.Read();
        }

        async static Task addAsyncFunc()
        {
            try
            {
                int[] arr = new int[5];
                arr[1] = 8;
            }
            catch(Exception e)
            {
                await ExceptionOccured();
                Console.WriteLine("Received the data from awaited task");
            }

            finally
            {
                await ReleasingResources();
                Console.WriteLine("Garbage Cleaned ....");
            }

        }
        async static Task ExceptionOccured()
        {
            Console.WriteLine("Array Exception Occured");
        }

        async static Task ReleasingResources()
        {
            Console.WriteLine("Resources are being released..");
        }
    }
}
