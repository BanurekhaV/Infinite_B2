using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class VwEmpdatum
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Gender { get; set; }
        public double? Salary { get; set; }
        public string Deptname { get; set; }
    }
}
