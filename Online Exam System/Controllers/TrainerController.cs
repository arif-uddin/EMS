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
            model.CoursesLookup = _lookUp.GetCourses();
            model.BatchLookup = _lookUp.GetBatches();

            return View("~/Views/Shared/Trainer/_TrainerAdd.cshtml",model);
        }


        public PartialViewResult GetTrainerListPartial()
        {
            List<Trainer> TrainerList = _trainerManager.GetAll();
            return PartialView("~/Views/Shared/Trainer/_TrainerList.cshtml", TrainerList);
        }
        public PartialViewResult Details(int Id)
        {
            Trainer trainer = new Trainer();
            trainer = _trainerManager.GetById(Id);
            return PartialView("~/Views/Shared/Trainer/_TrainerDetails.cshtml", trainer);
        }
    }
}