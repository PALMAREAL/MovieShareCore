using MovieShareCore.Data.Repositories;
using MovieShareCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public class DirectorService : ServiceBase, IDirectorService
    {

        public DirectorService(IUnitOfWork unitOfWork) 
            : base(unitOfWork) { }


        public async Task Create(Director director)
        {
            UoW.DirectorRepository.Insert(director).Wait(); 
            await UoW.SaveAsync();
        }

        public async Task Update(Director director)
        {
            UoW.DirectorRepository.Update(director).Wait();
            await UoW.SaveAsync();
        }

        public async Task Delete(int id)
        {
            UoW.DirectorRepository.Delete(id).Wait();
            await UoW.SaveAsync();
        }

        public async Task Delete(Director director)
        {
            UoW.DirectorRepository.Delete(director).Wait();
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

        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await UoW.CountryRepository.Get();
        }
    }
}
