using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day_4.Models
{
    public class Employee
    {
        //[Required(ErrorMessage ="Please provide user name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Please Re-enter Password")]
        [Compare("Password",ErrorMessage ="Passwords Does Not Match")]
        [Display(Name ="Re-Enter Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Please Enter Email")]
       // [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        //    ErrorMessage ="Enter Email In correct Format)")]
        public string Email { get; set; }
        [Range(21,60,ErrorMessage =("Age to be between 21 and 60 only"))]
        public int Age { get; set; }
    }
}