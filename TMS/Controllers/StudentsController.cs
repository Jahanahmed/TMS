using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMS.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Student student)
        {
            return View();
        }

        public JsonResult Info()
            {
            //if (id == null) return Json(false, JsonRequestBehavior.DenyGet);

            var student = new Student();
            student.ID = "1";
            student.Name = "Jamal";

            var jsonItem = new { student.Name };

            return Json(jsonItem, JsonRequestBehavior.AllowGet);
    }
    }

    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}