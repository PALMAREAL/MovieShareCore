using MovieShareCore.Data.Repositories;
using MovieShareCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public class MovieService : ServiceBase, IMovieService
    {
      
        public MovieService(IUnitOfWork unitOfWork): base(unitOfWork) { }


        public async Task Create(Movie movie)
        {
            await UoW.MovieRepository.Insert(movie)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task Update(Movie movie)
        {
            await UoW.MovieRepository.Update(movie)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task Delete(int id)
        {
            await UoW.MovieRepository.Delete(id)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task Delete(Movie movie)
        {
            await UoW.MovieRepository.Delete(movie)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task<Movie> GetEntity(int id)
        {
            return await UoW.MovieRepository.GetEntity(id);
        }
        
        public async Task<IEnumerable<Movie>> GetAllEntities()
        {
            return await UoW.MovieRepository.GetAllEntities();
        }

        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await UoW.CountryRepository.Get();
        }

        public async Task<IEnumerable<Director>> GetDirectors()
        {
            return await UoW.DirectorRepository.Get();
        }
    }
}
