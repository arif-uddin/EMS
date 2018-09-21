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
    public class QuestionRepository
    {
        EMSDbContext db = new EMSDbContext();

        public bool Add(Question question)
        {
            db.Questions.Add(question);
            return db.SaveChanges() > 0;
        }
        public bool Update(Question question)
        {
            db.Questions.Attach(question);
            db.Entry(question).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }
        public bool Delete(Question question)
        {
            question.IsDeleted = true;
            return Update(question);
        }

        public List<Question> GetAll()
        {
            return db.Questions.Where(c => c.IsDeleted == false).ToList();
        }

        public Question GetById(int id)
        {
            return db.Questions.Where(c => c.IsDeleted == true).FirstOrDefault(c => c.Id == id);
        }
    }
}
