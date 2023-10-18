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
        static Region region;
        static void Main(string[] args)
        {
            //var reg = db.Regions.ToList();

            //foreach(var r in reg)
            //{
            //    Console.WriteLine(r.RegionID + " " + r.RegionDescription);
            //}

            //  InsertData();
            //  UpdateData();
            DeleteData();
            Console.Read();

        }

        public static void DeleteData()
        {
            // region = db.Regions.Find(12);
            region = new Region();

            Console.WriteLine($"On instantiating, the Entity State : {db.Entry(region).State}");
            region.RegionID = 200;
            region.RegionDescription = "Banurekha";

            
            db.Regions.Add(region);
            Console.WriteLine($"Before SaveChanges, the Entity State : {db.Entry(region).State}");
            db.Regions.Remove(region);
           
            Console.WriteLine($"After SaveChanges, the Entity State : {db.Entry(region).State}");

            db.Database.Log = Console.Write;
            db.SaveChanges();
        }
        public static void UpdateData()
        {
             region = db.Regions.Find(12);

            Console.WriteLine($"Before SaveChanges, the Entity State : {db.Entry(region).State}");

            //make changes to the property
            region.RegionDescription = "Oldest Region";
            Console.WriteLine("----------------");
            Console.WriteLine($"Before SaveChanges, the Entity State : {db.Entry(region).State}");

            db.Database.Log = Console.Write;
            db.SaveChanges();
            Console.WriteLine("----------------");
            Console.WriteLine($"After SaveChanges, the Entity State : {db.Entry(region).State}");
        }
        public static void InsertData()
        {
            Console.WriteLine("Enter Region Id and Description :");
            region.RegionID = Convert.ToInt32(Console.ReadLine());
            region.RegionDescription = Console.ReadLine();
            db.Regions.Add(region);
            Console.WriteLine($"Before SaveChanges, the Entity State : {db.Entry(region).State}");

            db.Database.Log = Console.Write;
            db.SaveChanges();
            Console.WriteLine("Added a Region Successfully");
        }
    }
}
