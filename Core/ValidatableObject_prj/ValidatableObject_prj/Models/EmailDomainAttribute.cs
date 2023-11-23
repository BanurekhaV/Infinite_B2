using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidatableObject_prj.Models
{
    public class EmailDomainAttribute : ValidationAttribute
    {
        private readonly string reqdomain;
        public EmailDomainAttribute(string reqdomain)
        {
            this.reqdomain = reqdomain;
        }
        public override bool IsValid(object value)
        {
            string[] str = value.ToString().Split('@');
            return str[1].ToUpper() == reqdomain.ToUpper();
        }
    }
}
