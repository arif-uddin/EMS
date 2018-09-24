using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace Online_Exam_System.Controllers
{ 
    public class OrganizationController : Controller
    {
        OrganizationManager _organizationManager=new OrganizationManager();

        public PartialViewResult GetOrganizationCreatePartial()
        {
            return PartialView("~/Views/Shared/Organization/_OrganizationAdd.cshtml");
        }

        [HttpPost]
        public PartialViewResult GetOrganizationCreatePartial(Organization organization)
        {
            if (ModelState.IsValid)
            {
                _organizationManager.Add(organization);               
            }
            return PartialView("~/Views/Shared/Organization/_OrganizationAdd.cshtml");
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
    }
}