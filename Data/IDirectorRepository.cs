using MovieShareCore.Models;
using System.Threading.Tasks;

namespace MovieShareCore.Data
{
    public interface IDirectorRepository : IRepository<Director>
    {
        public Task<Director> GetByID(int id);
    }
}