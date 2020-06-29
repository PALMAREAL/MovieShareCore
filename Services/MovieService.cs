using MovieShareCore.Data;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public class MovieService : IMovieService
    {
        private IUnitOfWork UoW;

        public MovieService(IUnitOfWork unitOfWork)
        {
            UoW = unitOfWork;
        }

        public void Create(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
