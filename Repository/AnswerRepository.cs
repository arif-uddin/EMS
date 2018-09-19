using System;
using System.Collections.Generic;
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
    }
}
