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
    public class BatchRepository
    {
        EMSDbContext db = new EMSDbContext();

        public bool Add(Batch batch)
        {
            db.Batches.Add(batch);
            return db.SaveChanges() > 0;
        }
        public bool Update(Batch batch)
        {
            db.Batches.Attach(batch);
            db.Entry(batch).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool Delete(Batch batch)
        {
            batch.IsDeleted = true;
            return Update(batch);
        }

        public List<Batch> GetAll()
        {
            return db.Batches.Where(c => c.IsDeleted == false).ToList();
        }

        public Batch GetById(int id)
        {
            return db.Batches.Where(c => c.IsDeleted == true).FirstOrDefault(c => c.Id == id);
        }
    }
}
