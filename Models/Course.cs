using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
        public string Outline { get; set; }

        [Required]
        [Range(1,5)]
        public int Credit { get; set; }

        [Required]
        public int Duration { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Batch> Batches { get; set; } 
        public ICollection<Organization> Organizations { get; set; }
      
    }
}