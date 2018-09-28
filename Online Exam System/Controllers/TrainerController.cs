using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace Online_Exam_System.Controllers
{
    public class TrainerController : Controller
    {   
        TrainerManager _trainerManager = new TrainerManager();
        public ActionResult GetTrainerCreatePartial()
        {
            return View("~/Views/Shared/Trainer/_TrainerAdd.cshtml");
        }

        public JsonResult GetAllOrganization()
        {
            List<Trainer> trainers = _trainerManager.GetAll();
            return Json(trainers, JsonRequestBehavior.AllowGet);
        }
    }
}