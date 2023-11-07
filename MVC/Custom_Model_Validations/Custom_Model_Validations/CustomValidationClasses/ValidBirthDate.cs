using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Custom_Model_Validations.CustomValidationClasses
{
    //custom validation attribute class for validating DOB
    public sealed class ValidBirthDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime entered_dob = Convert.ToDateTime(value);
            DateTime mindt = Convert.ToDateTime("25/01/1985");
            DateTime maxdt = Convert.ToDateTime("25/01/1995");
            if (entered_dob >= mindt && entered_dob <= maxdt)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }
}