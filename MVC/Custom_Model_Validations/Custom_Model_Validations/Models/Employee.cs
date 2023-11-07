using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom_Model_Validations.Models
{
    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string Dept { get; set; }
        public decimal Salary { get; set; }
        public int? AddressId { get; set; }
    }
}