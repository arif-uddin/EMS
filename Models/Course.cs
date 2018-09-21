using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        [Range(3, 40, ErrorMessage = "Course name must have 3-40 characters!!")]
        public string Name { get; set; }
        public string Outline { get; set; }
        [Required]
        public int Credit { get; set; }
        [Required]
        public int Duration { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public bool IsDeleted { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public ICollection<Batch> Batches { get; set; } 
      
    }
}