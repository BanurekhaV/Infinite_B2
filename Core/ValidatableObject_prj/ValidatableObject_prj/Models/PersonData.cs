using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidatableObject_prj.Models
{
    public class PersonData : IValidatableObject
    {
        public int PersonId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Date Of Birth")]
        public DateTime Dob { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
        [Required]
        [EmailAddress]
        [Remote(action:"IsEmailInUse",controller:"Home")]
        public string Mail { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var property = new[] { "Dob" };
            if(Dob>DateTime.Now)
            {
                yield return new ValidationResult("Date of Birth cannot be a future date",property);
            }
            if(Dob<DateTime.Now.AddYears(-100))
            {
                yield return new ValidationResult("Date of Birth cannot be too past",property);
            }
        }

        public string FindByMail
    }
}
