using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        //create an object of the context class for any further database work
        static NorthwindEntities db = new NorthwindEntities();
        static Region region = new Region();
        static void Main(string[] args)
        {
            var reg = db.Regions.ToList();

            foreach(var r in reg)
            {
                Console.WriteLine(r.RegionID + " " + r.RegionDescription);
            }

            InsertData();
            Console.Read();

        }

        public static void InsertData()
        {
            Console.WriteLine("Enter Region Id and Description :");
            region.RegionID = Convert.ToInt32(Console.ReadLine());
            region.RegionDescription = Console.ReadLine();
            db.Regions.Add(region);
            db.SaveChanges();
            Console.WriteLine("Added a Region Successfully");
        }
    }
}
