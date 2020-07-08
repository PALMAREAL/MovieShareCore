using MovieShareCore.Models;
using System.Threading.Tasks;

namespace MovieShareCore.Data.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        public Task<Customer> GetEntity(int id);
    }
}