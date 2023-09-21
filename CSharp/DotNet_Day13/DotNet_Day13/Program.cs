using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day13
{
    class Accounts
    {
       public double Balance;

        public Accounts(double d)
        {
            Balance = d;
        }

        public  void Credit(double amt)
        {
            Balance += amt;
        }

        public void Debit(double amt)
        {
            Balance -= amt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Accounts(1000);
            var tasks = new Task[50];
            for(int i=0; i<tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => RandomlyUpdate(account));
            }
            Task.WaitAll(tasks);
            Console.WriteLine("All Tasks Done..");
            Console.WriteLine(account.Balance);
            Console.Read();
        }

        static void RandomlyUpdate(Accounts account)
        {
            var rand = new Random();
            for(int i=0; i<10; i++)
            {
                var amount = rand.Next(1, 100);   //25

                bool b = rand.NextDouble() < 0.5;
                if(b)
                {
                    account.Credit(amount);
                }
                else
                {
                    account.Debit(amount);
                }

            }
        }
    }
}
