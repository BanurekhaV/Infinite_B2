using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day11
{
    class EventsEg2
    {
        int data = 5;
        public delegate void NumberManipulator(int x);

        public event NumberManipulator ChangeNumEvent;

        public EventsEg2(int n)
        {
            this.ChangeNumEvent += new NumberManipulator(this.OnChangeNum); //registering an event with the delegate and hence a function
            setValue(n);
        }

        public void OnChangeNum(int x) // event handler
        {
           // data = x;
            Console.WriteLine($"Event Raised and the value from {data} is being changed to {x}");
        }

        public void setValue(int n) // responsible for raising an event 
        {
            
            if (data != n)   //data's value and input value are different
            {
                ChangeNumEvent(n);
            }
            else
            {
                Console.WriteLine("No Changes in the Value.. No Event");
            }
        }
    }

    class TestEvent
    {
        static void Main()
        {
            EventsEg2 eobj2 = new EventsEg2(5);  // No Event
            eobj2.setValue(15);  // Event will be raised
            eobj2.setValue(20);
            eobj2.setValue(5);
            eobj2 = null;
            GC.Collect(); // forcefull call to collect the objects released
            Console.WriteLine("Garbage Programming");
            Console.WriteLine("the Number of Generations are :" + GC.MaxGeneration);
           // Console.WriteLine("The generation number of the Object eobj is " + GC.GetGeneration(eobj2));
            Console.WriteLine("Total memory :" + GC.GetTotalMemory(false));

            Console.WriteLine("------------");
            EventsEg2 eobjnew = new EventsEg2(6);
            Console.WriteLine("Garabage Collection in Generation 0 is:" + GC.CollectionCount(0));
            Console.WriteLine("The generation number of the Object eobj is " + GC.GetGeneration(eobjnew));
            Console.WriteLine("Total memory :" + GC.GetTotalMemory(false));
            Console.Read();
        }
    }
}
