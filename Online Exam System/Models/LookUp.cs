using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace Online_Exam_System.Models
{
    public class LookUp
    {
        OrganizationManager _organizationManager = new OrganizationManager();
        CourseManager _courseManager = new CourseManager();
        BatchManager _batchManager = new BatchManager();

        public List<SelectListItem> GetOrganizations()
        {
            return _organizationManager.GetAll().Select(
                c => new SelectListItem() {Value = c.Id.ToString(), Text = c.Name}).ToList();
        }
        public List<SelectListItem> GetCourses()
        {
            return _courseManager.GetAll().Select(
                c => new SelectListItem() { Value = c.Id.ToString(), Text = c.Name }).ToList();
        }
        public List<SelectListItem> GetBatches()
        {
            return _batchManager.GetAll().Select(
                c => new SelectListItem() { Value = c.Id.ToString(), Text = c.BatchNo.ToString() }).ToList();
        }

    }
}