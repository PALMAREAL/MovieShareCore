using MovieShareCore.Data;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public class MovieService : ServiceBase, IMovieService
    {
      
        public MovieService(IUnitOfWork unitOfWork): base(unitOfWork) { }


        public async Task Create(Movie movie)
        {
            UoW.MovieRepository.Insert(movie);
            await UoW.SaveAsync();
        }

        public async Task Update(Movie movie)
        {
            UoW.MovieRepository.Update(movie);
            await UoW.SaveAsync();
        }

        public async Task Delete(int id)
        {
            UoW.MovieRepository.Delete(id);
            await UoW.SaveAsync();
        }

        public async Task Delete(Movie movie)
        {
            UoW.MovieRepository.Delete(movie);
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
    }
}
