using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;
using Models.ViewModels.TrainerVM;
using Online_Exam_System.Models;

namespace Online_Exam_System.Controllers
{
    public class TrainerController : Controller
    {   
        TrainerManager _trainerManager = new TrainerManager();
        LookUp _lookUp = new LookUp();
        public ActionResult GetTrainerCreatePartial()
        {
            var model = new TrainerAddVm();
            model.OrganizationsLookup = _lookUp.GetOrganizations();
            return View("~/Views/Shared/Trainer/_TrainerAdd.cshtml",model);
        }

        public JsonResult GetAllOrganization()
        {
            List<Trainer> trainers = _trainerManager.GetAll();
            return Json(trainers, JsonRequestBehavior.AllowGet);
        }
    }
}