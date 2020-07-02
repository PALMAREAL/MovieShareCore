using MovieShareCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public interface IDirectorService
    {
        public Task Create(Director director);

        public Task Update(Director director);

        public Task Delete(int id);

        public Task Delete(Director director);

        public Task<Director> GetById(int id);

        public Task<IEnumerable<Director>> GetAll();

    }
}