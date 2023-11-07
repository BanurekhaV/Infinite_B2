using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Custom_Model_Validations.CustomValidationClasses;

namespace Custom_Model_Validations.Models
{
    public class JobApplication
    {
        [Required]
        [Display(Name ="Applicant Name")]
        public string name { get; set; }
        [Range(3,7,ErrorMessage ="Experience must be from 3 to 7 years")]
        [Display(Name ="Years of Experience")]
        public int experience { get; set; }
        [Display(Name ="DOB")]
        [DataType(DataType.Date)]
        [ValidBirthDate(ErrorMessage="DOB should be between 01-25-1985 & 01-25-1995")]
        public DateTime birthdate { get; set; }
        [Required]
        [Display(Name ="Email ID")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$",ErrorMessage ="Invalid Email")]
        public string email { get; set; }
        [GenderValidation(ErrorMessage="Select Your Gender")]
        public string gender { get; set; }
        [Display(Name ="Expected Salary")]
        [RegularExpression(@"^(0(?!\.00)|[1-9]\d{0,6})\.\d{2}$",ErrorMessage ="Salary has to be like 6000.45")]
        public decimal expsal { get; set; }
        [SkillValidation(ErrorMessage="Select atleast 3 Skills")]
        public List<CheckBox> skills { get; set; }
        [Required]
        [Display(Name ="Do You Have a Passport ?")]
        public string HavePassport { get; set; }

    }
}