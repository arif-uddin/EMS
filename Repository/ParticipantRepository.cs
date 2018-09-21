using DatabaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    public class ParticipantRepository
    {
        EMSDbContext db = new EMSDbContext();

        public bool Add(Participant participant)
        {
            db.Participants.Add(participant);
            return db.SaveChanges() > 0;
        }
        public bool Update(Participant participant)
        {
            db.Participants.Attach(participant);
            db.Entry(participant).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool Delete(Participant participant)
        {
            participant.IsDeleted = true;
            return Update(participant);
        }

        public List<Participant> GetAll()
        {
            return db.Participants.Where(c => c.IsDeleted == false).ToList();
        }

        public Participant GetById(int id)
        {
            return db.Participants.Where(c => c.IsDeleted == true).FirstOrDefault(c => c.Id == id);
        }
    }
}
