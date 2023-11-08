using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Authentication_Prj.Models;
using System.Web.Security;

namespace Authentication_Prj.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }

        //Form to Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            using (AuthenticationDBContext context = new AuthenticationDBContext())
            {
                bool IsUserValid = context.Users.Any(u => u.UserName.ToLower() ==
                 model.UserName.ToLower() && u.UserPassword == model.UserPassword);
                if (IsUserValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Employees");
                }
                ModelState.AddModelError("", "Invalid UserName or Password");
                return View();
            }
        }
           
            public ActionResult Signup()
            {
                return View();
            }

        [HttpPost]
        public ActionResult Signup(User model)
        {
            using(AuthenticationDBContext context= new AuthenticationDBContext())
            {
                context.Users.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }
           
        }
    }
