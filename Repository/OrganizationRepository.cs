using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseContext;
using Models;

namespace Repository
{
    public class OrganizationRepository
    {
        EMSDbContext db = new EMSDbContext();

        public bool Add(Organization organization)
        {
             db.Organizations.Add(organization);
            return db.SaveChanges() > 0;
        }

        public bool Attach(int organizationId,int courseId)
        {
            Organization organization=new Organization{Id= organizationId };
            db.Organizations.Add(organization);
            db.Organizations.Attach(organization);
            Course course=new Course{Id = courseId};
            db.Courses.Add(course);
            db.Courses.Attach(course);

            organization.Courses.Add(course);

            return db.SaveChanges()>0;
        }


        public bool Update(Organization organization)
        {
            db.Organizations.Attach(organization);
            db.Entry(organization).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool Delete(Organization organization)
        {
            organization.IsDeleted = true;
            return Update(organization);
        }

        public List<Organization> GetAll()
        {
            return db.Organizations.Where(c => c.IsDeleted == false).ToList();
        }

        public Organization GetById(int id)
        {
            return db.Organizations.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
        }
    }
}
