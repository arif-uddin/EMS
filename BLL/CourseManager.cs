using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;


namespace BLL
{
    public class CourseManager
    {
        CourseRepository _courseRepository = new CourseRepository();
        public bool Add(Course course)
        {
            return _courseRepository.Add(course);
            
        }

        public bool Update(Course course)
        {
            return _courseRepository.Update(course);
        }

        public Course GetById(int Id)
        {
            return _courseRepository.GetById(Id);
        }

        public bool Delete(Course course)
        {
            return _courseRepository.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseRepository.GetAll();
        }
    }
}
