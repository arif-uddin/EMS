using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }    
        public string AddressLine2 { get; set; }    
        public string City { get; set; }    
        public int PostalCode { get; set; }     
        public string Country { get; set; }    
        public string Profession { get; set; }
        public string HighestAcademicQualification { get; set; }
        public byte Image { get; set; }
        public bool IsDeleted { get; set; }

        public int BatchId { get; set; }   
        public Batch Batch { get; set; }
    }   
}
