using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.DAL;

namespace WebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Student student )
        {
            student.Id = Guid.NewGuid();
            var db = new NuContext();
            db.Students.Add(student);
            db.SaveChanges();
            // return View();
            return RedirectToAction("Index");
        }
    }
}