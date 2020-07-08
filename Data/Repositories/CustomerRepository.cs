using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Data.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Customer> GetEntity(int id)
        {
            return await Task.Run(() => Get(m => m.Id == id, null, "Country").Result.FirstOrDefault());
        }
    }
}
