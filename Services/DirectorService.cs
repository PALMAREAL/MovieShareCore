using MovieShareCore.Data;
using MovieShareCore.Data.Repositories;
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
            await UoW.DirectorRepository.Insert(director)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task Update(Director director)
        {
            await UoW.DirectorRepository.Update(director)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task Delete(int id)
        {
            await UoW.DirectorRepository.Delete(id)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task Delete(Director director)
        {
            await UoW.DirectorRepository.Delete(director)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task<Director> GetById(int id)
        {
            return await UoW.DirectorRepository.GetById(id);
        }

        public async Task<IEnumerable<Director>> GetAll()
        {
            return await UoW.DirectorRepository.Get();
        }

        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await UoW.CountryRepository.Get();
        }
    }
}
