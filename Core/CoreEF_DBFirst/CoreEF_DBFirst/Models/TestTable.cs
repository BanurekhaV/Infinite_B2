using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class TestTable
    {
        public int Id { get; set; }
        public string Tname { get; set; }
        public DateTime Dob { get; set; }
        public int? Age { get; set; }
    }
}
