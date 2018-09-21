using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;




namespace Models
{
    public class Organization
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        [Range(5,40,ErrorMessage = "Organization name must have 5-40 characters!!")]
        public string Name { get; set; }
        public string  Address { get; set; }
        [Required]
        [Range(11,11,ErrorMessage = "Your contact number is invalid!!")]
        public long ContactNo { get; set; }
        public string About { get; set; }
        public byte  Logo { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Course> Courses { get; set; }
        
        
    }
}