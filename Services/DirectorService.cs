using MovieShareCore.Data;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public class DirectorService : IDirectorService
    {

        private IUnitOfWork UoW;

        public DirectorService(IUnitOfWork unitOfWork)
        {
            UoW = unitOfWork;
        }

        public void Create(Director director)
        {
            throw new NotImplementedException();
        }

        public void Update(Director director)
        {
            throw new NotImplementedException();
        }

        public void Delete(Director director)
        {
            throw new NotImplementedException();
        }

        public Director GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Director> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
