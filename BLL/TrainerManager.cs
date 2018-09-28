using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BLL
{
    public class TrainerManager
    {
        TrainerRepository _trainerRepository = new TrainerRepository();

        public bool Add(Trainer trainer)
        {
            return _trainerRepository.Add(trainer);
        }

        public List<Trainer> GetAll()
        {
            return _trainerRepository.GetAll();
        }

        public bool Delete(Trainer trainer)
        {
            return _trainerRepository.Delete(trainer);
        }

        public Trainer GetById(int Id)
        {
            return _trainerRepository.GetById(Id);
        }

        public bool Update(Trainer trainer)
        {
            return _trainerRepository.Update(trainer);
        }
    }
}
