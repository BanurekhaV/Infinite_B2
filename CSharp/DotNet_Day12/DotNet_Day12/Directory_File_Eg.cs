using System;
using System.IO;

namespace DotNet_Day12
{
    class Directory_File_Eg
    {
        static void Main()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Banu\Infinite\B2\CSharp");
            if (dirinfo.Exists)
            {
                Console.WriteLine("The directory Exists");
                //if exists, get all the subdirectories
                DirectoryInfo[] dirs = dirinfo.GetDirectories();
                foreach(object dirnames in dirs)
                {
                    Console.WriteLine(dirnames.ToString());
                }
            }
            else
            {
                dirinfo.Create();
                Console.WriteLine("The new Directory is created");
            }

            //getting all the files of the given directory/folder
            FileInfo[] files = dirinfo.GetFiles();

            foreach(FileInfo fo in files)
            {
                Console.WriteLine("File Name : {0}   Size : {1}", fo.Name, fo.Length);
            }

            Console.Read();
        }
    }
}
