using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.DAL;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new NuContext();
            //var student1 = new Student() { Id = Guid.NewGuid(), Name = "Decha", LastName = "Tarat" };
            //db.Students.Add(student1);
            //var p = new Person() { Id = Guid.NewGuid(), Name = "Person", LastName = "Person" };
            //db.People.Add(p);

            //var profess = new Professor() { Id = Guid.NewGuid(), Name = "Profess", LastName = "Profess" };
            //db.People.Add(profess);
            //var d = new Department() { Id = Guid.NewGuid(), NameEng = "Engineering", NameTh = "วิศวกรรมศาสตร์" };
            //db.Departments.Add(d);
            //db.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}