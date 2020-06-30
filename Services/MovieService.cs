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


        public void Create(Movie movie)
        {
            UoW.MovieRepository.Insert(movie);
        }

        public void Update(Movie movie)
        {
            UoW.MovieRepository.Update(movie);
        }

        public void Delete(Movie movie)
        {
            UoW.MovieRepository.Delete(movie);
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
