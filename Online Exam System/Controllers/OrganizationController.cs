using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;
using Models.ViewModels.OrganizationVM;
using Online_Exam_System.Models;

namespace Online_Exam_System.Controllers
{ 
    public class OrganizationController : Controller
    {
        OrganizationManager _organizationManager=new OrganizationManager();
        LookUp _lookUp=new LookUp();

        public PartialViewResult GetOrganizationCreatePartial()
        {
            return PartialView("~/Views/Shared/Organization/_OrganizationAdd.cshtml");
        }

        [HttpPost]
        public ActionResult GetOrganizationCreatePartial(Organization organization, HttpPostedFileBase file)
        {
            
            if (ModelState.IsValid)
            {
                organization.Logo = new byte[file.ContentLength];
                file.InputStream.Read(organization.Logo, 0, file.ContentLength);

                _organizationManager.Add(organization);               
            }
            return View("~/Views/Dashboard/Dashboard.cshtml");
        }

        public PartialViewResult GetOrganizationListPartial()
        {   
            List<Organization> organizationList =   _organizationManager.GetAll();
            return PartialView("~/Views/Shared/Organization/_OrganizationList.cshtml",organizationList);
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            Organization organization=new Organization();   
            organization=_organizationManager.GetById(Id);
            _organizationManager.Delete(organization);
            return View("~/Views/Dashboard/Dashboard.cshtml");
        }

        public ActionResult Edit(int Id)    
        {
            Organization organization = new Organization();
            organization = _organizationManager.GetById(Id);

            return View("~/Views/Shared/Organization/_OrganizationEdit.cshtml", organization);
        }

        [HttpPost]
        public ActionResult Update(Organization organization, HttpPostedFileBase image)
        {
            organization.Logo = new byte[image.ContentLength];
            image.InputStream.Read(organization.Logo, 0, image.ContentLength);
            _organizationManager.Update(organization);

            //return GetOrganizationListPartial();
            return View("~/Views/Dashboard/Dashboard.cshtml");
        }

        public PartialViewResult Details(int Id)
        {
            Organization organization = new Organization();
            organization = _organizationManager.GetById(Id);
            return PartialView("~/Views/Shared/Organization/_OrganizationDetails.cshtml", organization);
        }

        public PartialViewResult LoadOrganizationCourseAddPage(int id)
        {

            OrganizationCourseAddVM model=new OrganizationCourseAddVM();
            model.Id = id;
            var org= _organizationManager.GetById(id);
            model.Name = org.Name;
            model.CoursesLookUp = _lookUp.GetCourses();
            return PartialView("~/Views/Shared/Organization/_OrganizationCourseAdd.cshtml",model);
        }

        public PartialViewResult OrganizationCourseAdd(OrganizationCourseAddVM obj)
        {
            //Organization org= new Organization();
            //List<Course> courseList = new List<Course>();
            //Course course = new Course();
            //org.Id = obj.Id;
            //course.Id = obj.CourseId;
            //courseList.Add(course);
            //org.Courses = courseList;
            //_organizationManager.Add(org);

            return PartialView("~/Views/Shared/Organization/_OrganizationCourseAdd.cshtml");
        }
    }
}