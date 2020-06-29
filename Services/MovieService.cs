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

        public Movie GetById(int id)
        {
            return UoW.MovieRepository.GetByID(id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return UoW.MovieRepository.Get();
        }
    }
}
