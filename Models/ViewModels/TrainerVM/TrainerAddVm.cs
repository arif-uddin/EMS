using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Models.ViewModels.TrainerVM
{
   public class TrainerAddVm 
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsLead { get; set; }
        [Required]
        public string RegNo { get; set; }
        [Required]
        public string ContactNo { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public byte Image { get; set; }
        public bool IsDeleted { get; set; }
        public List<SelectListItem> OrganizationsLookup { get; set; }
        public List<SelectListItem> CoursesLookup { get; set; }
        public List<SelectListItem> BatchLookup { get; set; }

    }
}
