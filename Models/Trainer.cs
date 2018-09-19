using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Trainer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsLead { get; set; }  
        [Required]
        public string RegNo { get; set; }
        [Required]
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public byte Image { get; set; }
        public bool IsDeleted { get; set; }
        public int OrganizationId { get; set; } 
        public Organization Organization { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int BatchId { get; set; }
        public Batch Batch { get; set; }
    }
}
