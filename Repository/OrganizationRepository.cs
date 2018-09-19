using System;
using System.Collections.Generic;
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
    }
}
