using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class Table1
    {
        public int Tid { get; set; }
        public string Tname { get; set; }
        public string Tgrade { get; set; }
        public int? Tpercentage { get; set; }
    }
}
