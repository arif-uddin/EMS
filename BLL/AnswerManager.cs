using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BLL
{
    class AnswerManager
    {
        AnswerRepository _answerRepository = new AnswerRepository();

        public bool Add(Answer answer)
        {
            return _answerRepository.Add(answer);
        }
    }
}
