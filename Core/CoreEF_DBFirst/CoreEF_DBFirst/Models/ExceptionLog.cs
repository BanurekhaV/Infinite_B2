using System;
using System.Collections.Generic;

#nullable disable

namespace CoreEF_DBFirst.Models
{
    public partial class ExceptionLog
    {
        public int Logid { get; set; }
        public string ExMessage { get; set; }
        public string ExType { get; set; }
        public string ExSource { get; set; }
        public string ExUrl { get; set; }
        public DateTime? LogDate { get; set; }
    }
}
