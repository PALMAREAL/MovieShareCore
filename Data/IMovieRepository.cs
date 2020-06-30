using MovieShareCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieShareCore.Data
{
    public interface IMovieRepository : IRepository<Movie>
    {
        public Task<Movie> GetEntity(int id);

        public Task<IEnumerable<Movie>> GetAllEntities();
    }
}