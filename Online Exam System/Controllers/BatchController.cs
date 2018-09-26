using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace Online_Exam_System.Controllers
{
    public class BatchController : Controller
    {
        // GET: Batch
        BatchManager _batchManager = new BatchManager();

        public PartialViewResult GetBatchCreatePartial()
        {
            return PartialView("~/Views/Shared/Batch/_BatchAdd.cshtml");
        }

        [HttpPost]
        public ActionResult GetBatchCreatePartial(Batch batch)
        {

            if (ModelState.IsValid)
            {
             _batchManager.Add(batch);
            }
            return View("~/Views/Dashboard/Dashboard.cshtml");
        }
        public PartialViewResult GetBatchListPartial()
        {
            List<Batch> batchList = _batchManager.GetAll();
            return PartialView("~/Views/Shared/Batch/_BatchList.cshtml", batchList);
        }

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            Batch batch = new Batch();
            batch = _batchManager.GetById(Id);
            _batchManager.Delete(batch);
            return View("~/Views/Dashboard/Dashboard.cshtml");
        }

        public PartialViewResult Edit(int Id)
        {
            Batch batch = new Batch();
            batch = _batchManager.GetById(Id);

            return PartialView("~/Views/Shared/Batch/_BatchEdit.cshtml", batch);
        }
        public ActionResult Update(Batch batch)
        {
            _batchManager.Update(batch);

            return GetBatchListPartial();
        }

        public PartialViewResult Details(int Id)
        {
            Batch batch = new Batch();
            batch = _batchManager.GetById(Id);
            return PartialView("~/Views/Shared/Batch/_BatchDetails.cshtml", batch);
        }



    }
}