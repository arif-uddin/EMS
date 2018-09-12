using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseContext;
using Models;

namespace Repository
{
    public class CourseRepository
    {
        EMSDbContext db = new EMSDbContext();
        public bool Add(Course course)
        {
            db.Courses.Add(course);
            return db.SaveChanges() > 0;
        }
    }
}
