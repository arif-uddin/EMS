using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Answer
    {
        public int Id { get; set; }
        [Required]
        public string Options { get; set; }
        public bool CorrectAns { get; set; }
        public Question Question { get; set; }
        public int QuestionId { get; set; } 
        public bool IsDeleted { get; set; }

    }
}
