using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string ExamType { get; set; }
        public string Code { get; set; }
        [Required]
        public string Topic { get; set; }
        [Required]
        public int FullMarks { get; set; }
        [Required]
        public TimeSpan TimeDuration { get; set; }

        public int  OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public int CourseId { get; set; }   
        public Course Course { get; set; }
        public bool IsDeleted { get; set; }


    }
}
