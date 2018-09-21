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
            return db.Organizations.Where(c => c.IsDeleted == true).FirstOrDefault(c => c.Id == id);
        }
    }
}
