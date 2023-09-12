using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day7
{
    class Employee
    {
        //decl properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        //initializing the above properties thru constructor

        public Employee(int id, string name, string job, double salary, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Job = job;
            this.Salary = salary;
            this.Department = dept;
        }
        //1.
        public object this[int index]
        {
            get
            {
                if (index == 0) 
                    return ID;
                else if (index == 1) 
                    return Name;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Department;
                else
                    return null;
            }
            set
            {
                if (index == 0)  
                    ID = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Job = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDouble(value);
                else if (index == 4)
                    Department = value.ToString();
            }
        }

        //2. overloaded indexer with string type of index
        public object this[string s]
        {
            get {
                if (s == "ID")
                    return ID;
                else if (s == "Name")
                    return Name;
                else if (s == "Job")
                    return Job;
                else if (s == "Salary")
                    return Salary;
                else if (s == "Department")
                    return Department;
                else
                    return null;
            }
            set {
                if (s == "ID")
                    ID = Convert.ToInt32(value);
                else if (s == "Name")
                     Name=value.ToString();
                else if (s == "Job")
                     Job = value.ToString();
                else if (s == "Salary")
                     Salary = Convert.ToDouble(value);
                else if (s == "Department")
                     Department = value.ToString();
            }
        }

    }
        class Indexer_Eg2
        {
            static void Main()
            {
                Employee emp = new Employee(101, "Shreyank", "Associate", 17000, "IT");

            //accessing the properties of employee using indexers
            Console.WriteLine("Accessing the object details using int index");
             Console.WriteLine("Employee ID =" + emp[0]);
            Console.WriteLine("Employee Name =" + emp[1]);
            Console.WriteLine("Employee Job =" + emp[2]);
            Console.WriteLine("Employee Salary =" + emp[3]);
            Console.WriteLine("Employee Dept =" + emp[4]);

            //set few values of the object using 1st indexer
            emp[1] = "Anshika";
            emp[2] = "Developer";
            emp[3] = 22000;


            //set values of the object using 2nd indexer
            emp["ID"] = 200;
            emp["Department"] = "HR";

            Console.WriteLine("----------After setting new Values---------");
            Console.WriteLine("Employee ID =" + emp["ID"]);
            Console.WriteLine("Employee Name =" + emp["Name"]);
            Console.WriteLine("Employee Job =" + emp["Job"]);
            Console.WriteLine("Employee Salary =" + emp["Salary"]);
            Console.WriteLine("Employee Dept =" + emp["Department"]);
            Console.Read();
        }
    }

    }

