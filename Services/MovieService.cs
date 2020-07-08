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
            UoW.MovieRepository.Insert(movie).Wait();
            await UoW.SaveAsync();
        }

        public async Task Update(Movie movie)
        {
            UoW.MovieRepository.Update(movie).Wait();
            await UoW.SaveAsync();
        }

        public async Task Delete(int id)
        {
            UoW.MovieRepository.Delete(id).Wait();
            await UoW.SaveAsync();
        }

        public async Task Delete(Movie movie)
        {
            UoW.MovieRepository.Delete(movie).Wait();
            await UoW.SaveAsync();
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

        public async Task<IEnumerable<Genre>> GetGenres()
        {
            return await UoW.GenreRepository.Get();
        }
    }
}
