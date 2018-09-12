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
        public int Code { get; set; }
        [Required]
        [Range(1,40)]
        public string Name { get; set; }
        public string  Address { get; set; }
        public long ContactNo { get; set; }
        public string About { get; set; }
        public string  Logo { get; set; }
        public List<Course> Courses { get; set; }
        
    }
}