using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? Salary { get; set; }
        public string Phone { get; set; }
    }
}
