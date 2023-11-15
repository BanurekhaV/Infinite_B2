using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelValidations.Models;

namespace ModelValidations.Controllers
{
    public class JobApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(JobApplication ja)
        {
            if (string.IsNullOrEmpty(ja.Name))
                ModelState.AddModelError(ja.Name, "Please enter your Name");
            else if (ja.Name == "Banurekha")
                ModelState.AddModelError(ja.Name, "You are not allowed for this Job");
            if (ja.DOB == Convert.ToDateTime("01-01-0001 00:00:00"))
                ModelState.AddModelError(nameof(ja.DOB), "Enter your Date of Birth");
            else if (ja.DOB > DateTime.Now)
                ModelState.AddModelError(nameof(ja.DOB), "DOB cannot be future date");
            else if (ja.DOB < new DateTime(1995, 1, 1))
                ModelState.AddModelError(nameof(ja.DOB), "DOB should be greater tahn 1995");
            if (string.IsNullOrEmpty(ja.Gender))
                ModelState.AddModelError(ja.Gender, "Please Select Your Gender");
            if (ja.Experience.ToString() == "Select")
                ModelState.AddModelError(ja.Experience, "Please Select Your Experience");
            if (!ja.TermsAccept)
                ModelState.AddModelError(nameof(ja.TermsAccept), "You must Accpet The Terms");
            if (ModelState.IsValid)
                return View("Accepted", ja);
            else
                return View();
        }
    }
}
