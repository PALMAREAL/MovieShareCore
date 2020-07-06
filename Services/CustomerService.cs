using MovieShareCore.Data;
using MovieShareCore.Data.Repositories;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public class CustomerService : ServiceBase, ICustomerService
    {

        public CustomerService(IUnitOfWork unitOfWork) 
            : base(unitOfWork) { }


        public async Task Create(Customer customer)
        {
            await UoW.CustomerRepository.Insert(customer)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task Update(Customer customer)
        {
            await UoW.CustomerRepository.Update(customer)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task Delete(int id)
        {
            await UoW.CustomerRepository.Delete(id)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task Delete(Customer customer)
        {
            await UoW.CustomerRepository.Delete(customer)
                .ContinueWith(x => UoW.SaveAsync());
        }

        public async Task<Customer> GetById(int id)
        {
            return await UoW.CustomerRepository.GetById(id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await UoW.CustomerRepository.Get();
        }
    }
}
