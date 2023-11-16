using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class Employeedummy
    {
        public int? Id { get; set; }
        public string EmpName { get; set; }
        public double? EmpSalary { get; set; }
        public int? EmpDept { get; set; }
    }
}
