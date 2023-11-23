using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ValidatableObject_prj.Models
{
    public class Users
    {
        [EmailDomain(reqdomain:"Infinite.com",ErrorMessage ="" +
            "Email Domain must be Infinite.com")]
      
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


        public static string FindByMailAsync(string mail)
        {
            if (mail == "banu@gmail.com")
            {
                return "exists";
            }

            return "not exists";
        }

    }

    
}
