using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models.ViewModels.OrganizationVM
{
    public class OrganizationCourseAddVM
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string  Name { get; set; }   
        public List<SelectListItem> CoursesLookUp { get; set; }
    }
}
