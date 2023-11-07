using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Custom_Model_Validations.CustomValidationClasses
{
    public class GenderValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToString(value) == "M" || Convert.ToString(value) == "F")
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }
}