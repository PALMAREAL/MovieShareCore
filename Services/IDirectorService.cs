using MovieShareCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public interface IDirectorService
    {
        public void Create(Director director);

        public void Update(Director director);

        public void Delete(Director director);

        public Director GetById(int id);

        public Task<IEnumerable<Director>> GetAll();

    }
}