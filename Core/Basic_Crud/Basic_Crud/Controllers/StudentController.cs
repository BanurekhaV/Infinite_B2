using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_Crud.Models;

namespace Basic_Crud.Controllers
{
    public class StudentController : Controller
    {
        //create a reference object of the Service Interface
        readonly IStudentRepository isr = null;

        //Initializing the readonly object with the Service Interface
        //thru constructor injection
        public StudentController(IStudentRepository repo)
        {
            isr = repo;
        }

        //public JsonResult Index()
        //{
        //    List<Student> allstudents = isr.GetAllstudents();
        //    return Json(allstudents);
        //}
        public IActionResult Index()
        {
            List<Student> allstudents = isr.GetAllstudents();
            return View(allstudents);
        }

        public JsonResult GetStudentById(int id)
        {
            Student s = isr.GetByStudentId(id);
            return Json(s);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            List<Student>newlist=isr.Create(s);
            return View("Index",newlist);           
        }
        public IActionResult Update(int id)
        {
            Student std = isr.GetByStudentId(id);
            return View(std);
        }

        [HttpPost]
        public IActionResult Update(int id, Student s)
        {
            Student std_upd = isr.Update(id, s);
            return View("Updated",std_upd);
        }
    }
}
