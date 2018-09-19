using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Tag
    {
        public int Id { get; set; }
        public string tag { get; set; }
        public int  CourseId { get; set; }  
        public Course Course { get; set; }  

    }
}
