using MovieShareCore.Models;
using System.Threading.Tasks;

namespace MovieShareCore.Data
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        public Task<Customer> GetByID(int id);
    }
}