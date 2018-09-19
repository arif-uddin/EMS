using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Exam_System.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }

        public PartialViewResult GetOrganizationCreatePartial()
        {
            return PartialView("~/Views/Shared/Organization/_OrganizationAdd.cshtml");
        }
    }
}