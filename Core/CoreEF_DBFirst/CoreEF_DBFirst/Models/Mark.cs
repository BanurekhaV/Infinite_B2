using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class Mark
    {
        public string Stdname { get; set; }
        public string ClassSubject { get; set; }
        public int? Marks { get; set; }
    }
}
