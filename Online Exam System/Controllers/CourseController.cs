using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace Online_Exam_System.Controllers
{
    public class CourseController : Controller
    {
        CourseManager _courseManager = new CourseManager();
       
        public ActionResult Add(Course course)
        {
           // _courseManager.Add(course);
            return View();
        }
    }
}