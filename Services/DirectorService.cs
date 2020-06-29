using MovieShareCore.Data;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public class DirectorService : ServiceBase, IDirectorService
    {

        public DirectorService(IUnitOfWork unitOfWork) : base(unitOfWork) { }


        public void Create(Director director)
        {
            UoW.DirectorRepository.Insert(director);
        }

        public void Update(Director director)
        {
            UoW.DirectorRepository.Update(director);
        }

        public void Delete(Director director)
        {
            UoW.DirectorRepository.Delete(director);
        }

        public Director GetById(int id)
        {
            return UoW.DirectorRepository.GetByID(id);
        }

        public async Task<IEnumerable<Director>> GetAll()
        {
            return await UoW.DirectorRepository.Get();
        }
    }
}
