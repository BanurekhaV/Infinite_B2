using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Custom_Model_Validations.Models
{
    //view model of multiple models
    public class EmpFullDetails
    {
        public Employee employee { get; set; }
        public Address address { get; set; }
        public string PageTitle { get; set; }
    }
}