using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BLL
{
    public class OrganizationManager
    {
        OrganizationRepository _organizationRepository = new OrganizationRepository();

        public bool Add(Organization organization)
        {
            return _organizationRepository.Add(organization);
        }

        public bool Attach(int organizationId, int courseId)
        {
            return _organizationRepository.Attach(organizationId,courseId);
        }

        public List<Organization> GetAll()
        {
            return _organizationRepository.GetAll();
        }

        public bool Delete(Organization organization)
        {
            return _organizationRepository.Delete(organization);
        }

        public Organization GetById(int Id)
        {
            return _organizationRepository.GetById(Id);
        }

        public bool Update(Organization organization)
        {
            return _organizationRepository.Update(organization);
        }
    }
}
