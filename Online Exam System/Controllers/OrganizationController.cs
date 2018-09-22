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
        public PartialViewResult GetOrganizationCreatePartial(Organization organization)
        {
            if (ModelState.IsValid)
            {
                _organizationManager.Add(organization);               
            }
            return PartialView("~/Views/Shared/Organization/_OrganizationAdd.cshtml");
        }

    }
}