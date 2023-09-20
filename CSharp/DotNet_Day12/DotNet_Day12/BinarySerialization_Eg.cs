using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DotNet_Day12
{
    [Serializable]   // Data Annotation, Attribute, Metat Data
    class BinarySerialization_Eg
    {
        public int EId;
        
        public string EName;

        static void Main()
        {
            BinarySerialization_Eg bse = new BinarySerialization_Eg()
            {
                EId=1,
                EName="Harshitha"
            };

            //to serialize the above object (bse), we can use either
            //the interface IFormatter or the derived class BinaryFormatter
            //IFormatter formatter = new BinaryFormatter();  or
            BinaryFormatter bf = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Banu\Infinite\b2\File1.txt",
                FileMode.Create, FileAccess.Write);

            bf.Serialize(stream, bse);
            stream.Flush();
            stream.Close();

            Console.Read();
        }
    }
}
