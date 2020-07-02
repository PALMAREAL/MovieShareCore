using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Data
{
    public class DirectorRepository : Repository<Director>, IDirectorRepository
    {
        public DirectorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Director> GetByID(int id)
        {
            return await Task.Run(() => Get(m => m.Id == id).Result.FirstOrDefault());
        }
    }
}
