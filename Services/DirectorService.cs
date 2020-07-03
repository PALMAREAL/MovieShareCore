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

        public DirectorService(IUnitOfWork unitOfWork) 
            : base(unitOfWork) { }


        public async Task Create(Director director)
        {
            UoW.DirectorRepository.Insert(director);
            await UoW.SaveAsync();
        }

        public async Task Update(Director director)
        {
            UoW.DirectorRepository.Update(director);
            await UoW.SaveAsync();
        }

        public async Task Delete(int id)
        {
            UoW.DirectorRepository.Delete(id);
            await UoW.SaveAsync();
        }

        public async Task Delete(Director director)
        {
            UoW.DirectorRepository.Delete(director);
            await UoW.SaveAsync();
        }

        public async Task<Director> GetById(int id)
        {
            return await UoW.DirectorRepository.GetById(id);
        }

        public async Task<IEnumerable<Director>> GetAll()
        {
            return await UoW.DirectorRepository.Get();
        }
    }
}
