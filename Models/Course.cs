using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Course
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Outline { get; set; }
        public int Credit { get; set; }
        public int Duration { get; set; }
        public string Tags { get; set; }
    }
}