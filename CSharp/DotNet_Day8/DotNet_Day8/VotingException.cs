using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day8
{
    //userderfined exception class
    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg)
        {

        }
    }

    //when to raise the above exception class object
    class Vote
    {
        int age;

        public void GetAge()
        {
            Console.WriteLine("Enter your Age :");
            age = int.Parse(Console.ReadLine());

            if(age<18)
            {
                throw (new VotingException("Age Should be greater than 18 to Vote .."));
            }
            else
                Console.WriteLine("Thanks for Voting..");
        }
    }

    class TestException
    {
        public static void Main()
        {
            Vote vote = new Vote();
            try
            {
                vote.GetAge(); // this decides whether exception would be raised or not
            }
            catch(VotingException ve)
            {
                Console.WriteLine(ve.Message);
            }
                        
            Console.Read();
        }
    }
}
