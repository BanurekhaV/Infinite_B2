using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud.Models
{
    public class Student
    {
        public int StdId { get; set; }
        public string StdName { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }
    }
}
