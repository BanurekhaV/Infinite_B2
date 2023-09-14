using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day9
{
    class Genic_Eg
    { 
        static void ListEg()
        {
            List<int> numlist = new List<int>();
            numlist.Add(450);
            numlist.Add(12);
            numlist.Add(123);

            numlist.Sort();
            foreach(int x in numlist)
            {
                Console.WriteLine(x);
            }

            List<string> strlist = new List<string>();
            strlist.Add("5");
            strlist.Add("Gautham");
            strlist.Add("Chandan");
            strlist.Add("Nayana");
            Console.WriteLine("---------");
            strlist.Sort();
            foreach(var item in strlist)
            {
                Console.WriteLine(item);
            }
        }

        static void DictionaryEg()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(2, "Red");
            dictionary.Add(1, "Blue");
            dictionary.Add(3, "Green");
            dictionary.Add(4, "Yellow");
           
            foreach(int k in dictionary.Keys)
            {
                Console.WriteLine(k);
            }

            foreach(string s in dictionary.Values)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------");
            foreach(KeyValuePair<int,string> kvp in dictionary)
            {
                Console.Write(kvp.Key);
                Console.Write(kvp.Value);
                Console.WriteLine();
            }

            Console.WriteLine("------------");
            Console.WriteLine("Enter a Key :");
            int ky = Convert.ToInt32(Console.ReadLine());
            if(dictionary.ContainsKey(ky))
            {
                Console.Write(ky + "Represents" + " " + dictionary[ky]);
            }
            else
                Console.WriteLine("Enter a Valid Key");
        }
         static void Main()
        {
            // ListEg();
            DictionaryEg();
            Console.Read();
        }

    }
}
