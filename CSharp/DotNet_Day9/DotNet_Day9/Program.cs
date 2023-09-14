using System;
using System.Collections;
using System.Collections.Generic;


namespace DotNet_Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alist = new ArrayList();
            alist.Add(10);
            alist.Add("AAA");
            alist.Add(456.55f);
            alist.Add('d');
            alist.Add(true);
            alist.Insert(2, "HelloArray");

            //foreach(var item in alist)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Count of elements {0}", alist.Count);
            //Console.WriteLine("Capacity of the type is {0}", alist.Capacity);
            alist.Add("Rama");
            alist.Add("Seetha");
            alist.Add("Raavan");
            //Console.WriteLine("**************");
            //Console.WriteLine("Count of elements {0}", alist.Count);
            //Console.WriteLine("Capacity of the type is {0}", alist.Capacity);
            //inserting a range of values
            ArrayList alist2 = new ArrayList();
            alist2.Add("Sneha");
            alist2.Add("Neha");
            alist2.Add("Harish");
            alist2.Add("Gisrish");
            alist2.Add("Piyush");

            alist.InsertRange(6, alist2);
            // Console.WriteLine("Capacity of the type is {0}", alist2.Capacity);
            //Console.WriteLine("++++++++++++++++");
            //foreach(var v in alist)
            //{
            //    Console.WriteLine(v);
            //}

            //Console.WriteLine("Removal---------");
            // alist.Remove('F');
            // alist.RemoveAt(3);
            // alist.RemoveRange(3, 4);

            //sort an arraylist
            // alist.Sort(); Cannot sort an arraylist with different data types
            //alist2.Sort();
            //foreach (var v in alist2)
            //{
            //    Console.WriteLine(v);
            //}

            //working with hash table collection
            // Program.HashTableEg();
            //Program.SortedListEg();
             StackEg();
            Console.Read();
        }

        static void HashTableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("E005", "Bhavagna");
            ht.Add("E002", "Bhuiyash");
            ht.Add("E001", "Hannah");
            ht.Add("E003", "Anshika");
            ht.Add("E007", "Soumya");
           

            //we can iterate the collection either with the keys or with the values
            foreach(var item in ht.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }

            //in order to iterate the collection with both the keys and values
            Console.WriteLine("Using Dictionary Entry");
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }

            Console.WriteLine("Search a Key/Value");
            Console.WriteLine("Enter a key :");
            string empid = Console.ReadLine();
            if(ht.ContainsKey(empid))
            { 
                Console.WriteLine(empid + " = " + ht[empid]);
            }
            else
                Console.WriteLine(empid + " "+ "Key Does not exists");
        }

        static void SortedListEg()
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "Oracle");
            sl.Add("vb", "Visual Basic");
            sl.Add("cs", "CSharp");
            sl.Add("asp", "ASP.Net");

            foreach(var item in sl.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in sl.Values)
            {
                Console.WriteLine(item);
            }

            foreach(DictionaryEntry d in sl)
            {
                Console.Write(d.Key + " " + d.Value);
                Console.WriteLine();
            }
        }

        static void StackEg()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            foreach(object item in st)
            {
                Console.WriteLine(item);
            }
            st.Pop();
            Console.WriteLine(st.Peek());
                foreach (object item in st)
            {
                Console.WriteLine(item);
            }
        }
    }
}
