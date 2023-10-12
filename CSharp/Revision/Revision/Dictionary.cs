using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Dictionary
    {
        public static void dictionary_Example()
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Delhi", "NewDelhi");
            capitals.Add("TamilNadu", "Chennai");
            capitals.Add("WestBengal", "Kolkatta");
            capitals.Add("Maharashtra", "Mumbai");
            capitals.Add("Karnataka", "Bengaluru");
            capitals.Add("Telangana", "Hyderabad");

            foreach(var d in capitals)
            {
                Console.WriteLine(d);
            }

            foreach(KeyValuePair<string,string> kvp in capitals)
            {
                Console.WriteLine($"State is {kvp.Key}, and the Capital is {kvp.Value}");
            }
        }
    }
}
