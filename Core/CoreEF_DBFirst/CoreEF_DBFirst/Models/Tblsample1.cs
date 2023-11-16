using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class Tblsample1
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int? Sage { get; set; }
        public string Scity { get; set; }
        public string Sphone { get; set; }
    }
}
