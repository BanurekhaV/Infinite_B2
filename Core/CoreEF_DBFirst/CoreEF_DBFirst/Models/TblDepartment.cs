using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblEmployees = new HashSet<TblEmployee>();
        }

        public int DeptId { get; set; }
        public string Deptname { get; set; }
        public int? Budget { get; set; }

        public virtual ICollection<TblEmployee> TblEmployees { get; set; }
    }
}
