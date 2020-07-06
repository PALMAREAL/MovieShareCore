using MovieShareCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public interface ICustomerService
    {

        public Task Create(Customer customer);

        public Task Update(Customer customer);

        public Task Delete(int id);

        public Task Delete(Customer customer);

        public Task<Customer> GetById(int id);

        public Task<IEnumerable<Customer>> GetAll();

        public Task<IEnumerable<Country>> GetCountries();

    }
}