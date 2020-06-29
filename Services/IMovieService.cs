using MovieShareCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public interface IMovieService
    {
        public void Create(Movie movie);

        public void Update(Movie movie);

        public void Delete(Movie movie);

        public Movie GetById(int id);

        public Task<IEnumerable<Movie>> GetAll();
    }
}