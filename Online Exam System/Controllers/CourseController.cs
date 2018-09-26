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

        public PartialViewResult GetCourseCreatePartial()
        {
            return PartialView("~/Views/Shared/Course/_CourseAdd.cshtml");
        }


        [HttpPost]  
        public ActionResult GetCourseCreatePartial(Course course)
        {

            if (ModelState.IsValid)
            {
                _courseManager.Add(course);
            }
            return View("~/Views/Dashboard/Dashboard.cshtml");
        }

        public PartialViewResult GetCourseListPartial()
        {
            List<Course> courseList = _courseManager.GetAll();
            return PartialView("~/Views/Shared/Course/_CourseList.cshtml", courseList);
        }


        public ActionResult Add(Course course)
        {
            _courseManager.Add(course);
            return View();
        }


        [HttpPost]
        public ActionResult Delete(int Id)
        {
            Course course = new Course();
             course= _courseManager.GetById(Id);
            _courseManager.Delete(course);
            return View("~/Views/Dashboard/Dashboard.cshtml");

        }

        public ActionResult Edit(int Id)
        {
            Course course = new Course();
            course = _courseManager.GetById(Id);

            return View("~/Views/Shared/Course/_courseEdit.cshtml", course);
        }

        public ActionResult Update(Course course)
        {
            _courseManager.Update(course);

            return GetCourseListPartial();
        }


        public PartialViewResult Details(int Id)
        {
            Course course = new Course();
            course = _courseManager.GetById(Id);
            return PartialView("~/Views/Shared/Course/_CourseDetails.cshtml", course);
        }
    }
}