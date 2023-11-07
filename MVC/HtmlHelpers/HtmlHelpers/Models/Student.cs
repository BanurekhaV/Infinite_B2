using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HtmlHelpers.Models
{
    public class Student
    {
        [Display(Name ="student Roll Number")]
        public int RollNo { get; set; }
        [Display(Name ="Student Name")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }

}