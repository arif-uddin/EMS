using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repository;

namespace BLL
{
    public class BatchManager
    {
        BatchRepository _batchRepository = new BatchRepository();
        public void Add(Batch batch)
        {
            _batchRepository.Add(batch);
        }
        public List<Batch> GetAll()
        {
            return _batchRepository.GetAll();
        }

        public Batch GetById(int id)
        {
            return _batchRepository.GetById(id);
        }

        public bool Delete(Batch batch)
        {
            return _batchRepository.Delete(batch);
        }

        public bool Update(Batch batch)
        {
           return _batchRepository.Update(batch);
        }
    }
}
