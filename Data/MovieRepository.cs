using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Data
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Movie> GetEntity(int id)
        {
            return await Task.Run(() => Get(m => m.Id == id, null, "Genre").Result.FirstOrDefault());
        }
        
        public async Task<IEnumerable<Movie>> GetAllEntities()
        {
            return await Get(null, null, "Genre");
        }
    }
}
