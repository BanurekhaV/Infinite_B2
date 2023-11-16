using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class TblEmployee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Gender { get; set; }
        public double? Salary { get; set; }
        public int? DeptId { get; set; }

        public virtual TblDepartment Dept { get; set; }
    }
}
