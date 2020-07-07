using MovieShareCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public interface IMovieService
    {
        public Task Create(Movie movie);

        public Task Update(Movie movie);

        public Task Delete(int id);

        public Task Delete(Movie movie);

        public Task<Movie> GetEntity(int id);

        public Task<IEnumerable<Movie>> GetAllEntities();

        public Task<IEnumerable<Country>> GetCountries();

        public Task<IEnumerable<Director>> GetDirectors();

        public Task<IEnumerable<Genre>> GetGenres();
    }
}