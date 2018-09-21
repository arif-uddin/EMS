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
    class ExamRepository
    {
        EMSDbContext db = new EMSDbContext();

        public bool Add(Exam exam)
        {
            db.Exams.Add(exam);
            return db.SaveChanges() > 0;
        }
        public bool Update(Exam exam)
        {
            db.Exams.Attach(exam);
            db.Entry(exam).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool Delete(Exam exam)
        {
            exam.IsDeleted = true;
            return Update(exam);
        }

        public List<Exam> GetAll()
        {
            return db.Exams.Where(c => c.IsDeleted == false).ToList();
        }

        public Organization GetById(int id)
        {
            return db.Organizations.Where(c => c.IsDeleted == true).FirstOrDefault(c => c.Id == id);
        }
    }
}
