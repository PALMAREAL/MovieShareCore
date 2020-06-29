using MovieShareCore.Data;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public class CustomerService : ICustomerService
    {

        private IUnitOfWork UoW;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            UoW = unitOfWork;
        }

        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
