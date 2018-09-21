using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Batch
    {
        public int Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
        public string BatchNo { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDeleted { get; set; } 

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<Participant> Participants { get; set; }  

    }
}
