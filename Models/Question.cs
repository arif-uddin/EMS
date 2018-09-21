using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Q { get; set; }
        public string OptionType { get; set; }
        public List<Answer> Answers { get; set; }
        public bool IsDeleted { get; set; } 

    }
}
