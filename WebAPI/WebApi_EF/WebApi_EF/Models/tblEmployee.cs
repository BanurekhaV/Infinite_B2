//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi_EF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmployee
    {
        public int EID { get; set; }
        public string EName { get; set; }
        public string Gender { get; set; }
        public Nullable<double> Salary { get; set; }
        public Nullable<int> DeptId { get; set; }
    
        public virtual tblDepartment tblDepartment { get; set; }
    }
}
