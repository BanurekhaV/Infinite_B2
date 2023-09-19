using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day11
{
    public delegate string Mydelegate1(string str);
    class EventsEg1  //publisher class
    {
        //declare an event and associate it with the delegate
        event Mydelegate1 myEvent; // decl an event of particular delegate type

        public EventsEg1()
        {
            this.myEvent += new Mydelegate1(this.WelcomeUser);
            this.myEvent += new Mydelegate1(this.SecondFunction);
        }

        public string WelcomeUser(string uname)
        {
            return "Welcome User : " + " " + uname;
        }

        public string SecondFunction(string msg)
        {
            return msg + " " + " Hope you are enjoying events and delegates..?";
        }

        static void Main()
        {
            EventsEg1 eobj = new EventsEg1();
            string welcomemsg = eobj.myEvent("Infinite"); //raising an event
            Console.WriteLine(welcomemsg);
            Console.Read();
        }
    }
}
