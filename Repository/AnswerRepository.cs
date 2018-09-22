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
    public class AnswerRepository
    {
        private readonly EMSDbContext _db = new EMSDbContext();

        public bool Add(Answer answer)
        {
            _db.Answers.Add(answer);
            return _db.SaveChanges() > 0;
        }
        public bool Update(Answer answer)
        {
            _db.Answers.Attach(answer);
            _db.Entry(answer).State = EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
        public bool Delete(Answer answer)
        {
            answer.IsDeleted = true;
            return Update(answer);
        }

        public List<Answer> GetAll()
        {
            return _db.Answers.Where(c => c.IsDeleted == false).ToList();
        }

        public Answer GetById(int id)
        {
            return _db.Answers.Where(c => c.IsDeleted == true).FirstOrDefault(c => c.Id == id);
        }
    }
}
