using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ValidatableObject_prj.Models;

namespace ValidatableObject_prj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult UserData()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserData(Users user)
        {
            if (ModelState.IsValid)
                //  return RedirectToAction("Index");
                return RedirectToAction("IsEmailInUse(user.Email)");
            else
                return View();

        }
        [AcceptVerbs("Get","Post")] // if you want an action method to respond to both get and post
        public async Task<IActionResult>IsEmailInUse(string email)
        {
            //making a call to afunction of the class that checks the existence of a mail id in the database
            //returns the email if available else null
            var u = await Users.FindByMailAsync(email);
            if (u == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use")
            }
    }
}
