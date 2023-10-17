using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRelations
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. creating an in-memory cache to store data
            DataSet dsEmployment = new DataSet("Employment");

            //2. let us add the first datatable
            DataTable dtEmployees = new DataTable("Employees");

            //3. columns for the datatable
            DataColumn[] dcEmployees = new DataColumn[4];
            dcEmployees[0] = new DataColumn("EmpID", System.Type.GetType("System.Int32"));
            dcEmployees[1] = new DataColumn("EmpName", System.Type.GetType("System.String"));
            dcEmployees[2] = new DataColumn("EmpDepartment", System.Type.GetType("System.String"));
            dcEmployees[3] = new DataColumn("EmpStatusID", System.Type.GetType("System.Int32"));

            //4. Add the above created columns to the datatable
            dtEmployees.Columns.Add(dcEmployees[0]);
            dtEmployees.Columns.Add(dcEmployees[1]);
            dtEmployees.Columns.Add(dcEmployees[2]);
            dtEmployees.Columns.Add(dcEmployees[3]);

            //5. Now let us create rows for the datatable
            DataRow drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpID"] = "1";
            drEmpRows["EmpName"] = "Aishwarya";
            drEmpRows["EmpDepartment"] = "IT";
            drEmpRows["EmpStatusID"] = "1";

            //6. Add the above row to the datatable
            dtEmployees.Rows.Add(drEmpRows);

            //Continue the above 2 steps(5, 6) for as much as rows required
            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpID"] = "2";
            drEmpRows["EmpName"] = "Trisha";
            drEmpRows["EmpDepartment"] = "Finance";
            drEmpRows["EmpStatusID"] = "3";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpID"] = "3";
            drEmpRows["EmpName"] = "Vikram";
            drEmpRows["EmpDepartment"] = "Accounts";
            drEmpRows["EmpStatusID"] = "1";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpID"] = "4";
            drEmpRows["EmpName"] = "Karthik";
            drEmpRows["EmpDepartment"] = "Finance";
            drEmpRows["EmpStatusID"] = "3";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpID"] = "5";
            drEmpRows["EmpName"] = "Ravi";
            drEmpRows["EmpDepartment"] = "Operations";
            drEmpRows["EmpStatusID"] = "4";

            dtEmployees.Rows.Add(drEmpRows);

            drEmpRows = dtEmployees.NewRow();
            drEmpRows["EmpID"] = "6";
            drEmpRows["EmpName"] = "Shobha";
            drEmpRows["EmpDepartment"] = "Admin";
            drEmpRows["EmpStatusID"] = "4";

            dtEmployees.Rows.Add(drEmpRows);


            //7. Create another table to the dataset
            DataTable dtEmpStatus = new DataTable("EmployeeStatus");

            //8. Columns for tabale 2
            DataColumn[] dcStatus = new DataColumn[2];
            dcStatus[0] = new DataColumn("EmpStatusID", System.Type.GetType("System.Int32"));
            dcStatus[1] = new DataColumn("EmpStatus", System.Type.GetType("System.String"));

            dtEmpStatus.Columns.Add(dcStatus[0]);
            dtEmpStatus.Columns.Add(dcStatus[1]);


            //9. Rows for table 2
            DataRow drStatus = dtEmpStatus.NewRow();

            drStatus["EmpStatusID"] = "1";
            drStatus["EmpStatus"] = "Full Time";

            dtEmpStatus.Rows.Add(drStatus);

            drStatus = dtEmpStatus.NewRow();

            drStatus["EmpStatusID"] = "2";
            drStatus["EmpStatus"] = "Part Time";

            dtEmpStatus.Rows.Add(drStatus);

            drStatus = dtEmpStatus.NewRow();

            drStatus["EmpStatusID"] = "3";
            drStatus["EmpStatus"] = "Contract";

            dtEmpStatus.Rows.Add(drStatus);

            drStatus = dtEmpStatus.NewRow();

            drStatus["EmpStatusID"] = "4";
            drStatus["EmpStatus"] = "Intern";

            dtEmpStatus.Rows.Add(drStatus);

            //10. add both the datatables to the dataset
            dsEmployment.Tables.Add(dtEmployees);
            dsEmployment.Tables.Add(dtEmpStatus);

            //11. Setting up the relationship between the 2 datatables
            //11.1  - create primary and foreign key settings

            DataColumn parent = dsEmployment.Tables["EmployeeStatus"].Columns["EmpStatusID"];

            DataColumn child = dsEmployment.Tables["Employees"].Columns["EmpStatusID"];

            //11.2 - relating the 2 tables

            DataRelation emprel = new DataRelation("EmployeeStatusRelation", parent, child);

            //11.3 - add the above relationship to the dataset

            dsEmployment.Relations.Add(emprel);

            Console.WriteLine("==================================================");
            Console.WriteLine("Status ID       |     Employement Status");
            Console.WriteLine("---------------------------------------------------");

            foreach (DataRow row in dsEmployment.Tables["EmployeeStatus"].Rows)
            
                Console.WriteLine("{0}  |    {1}", row["EmpStatusID"], row["EmpStatus"]);
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("EmpId \t  | Emp name \t    |Department \t    |Employee Status");
                Console.WriteLine("-------------------------------------------------------------");
                foreach (DataRow row in dsEmployment.Tables["Employees"].Rows)
                {
              //  int irow = int.Parse(row["EmpStatusID"].ToString());

             //   DataRow currrow = dsEmployment.Tables["EmployeeStatus"].Rows[irow - 1];
                Console.WriteLine("{0} \t  |  {1} \t    | {2} \t    | {3}", row["EmpID"],
                    row["EmpName"], row["EmpDepartment"], row["EmpStatusID"]);
                }

            Console.WriteLine("=================================");
            Console.Read();
        }
    }
}
