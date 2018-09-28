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
    public class TrainerRepository
    {
        EMSDbContext db = new EMSDbContext();

        public bool Add(Trainer trainer)
        {
            db.Trainers.Add(trainer);
            return db.SaveChanges() > 0;
        }
        public bool Update(Trainer trainer)
        {
            db.Trainers.Attach(trainer);
            db.Entry(trainer).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool Delete(Trainer trainer)
        {
            trainer.IsDeleted = true;
            return Update(trainer);
        }

        public List<Trainer> GetAll()
        {
            return db.Trainers.Where(c => c.IsDeleted == false).ToList();
        }

        public Trainer GetById(int id)
        {
            return db.Trainers.Where(c => c.IsDeleted == false).FirstOrDefault(c => c.Id == id);
        }
    }
}
