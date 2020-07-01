using MovieShareCore.Data;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public class CustomerService : ServiceBase, ICustomerService
    {

        public CustomerService(IUnitOfWork unitOfWork) : base(unitOfWork) { }


        public async Task Create(Customer customer)
        {
            UoW.CustomerRepository.Insert(customer);
            await UoW.SaveAsync();
        }

        public async Task Update(Customer customer)
        {
            UoW.CustomerRepository.Update(customer);
            await UoW.SaveAsync();
        }

        public async Task Delete(int id)
        {
            UoW.CustomerRepository.Delete(id);
            await UoW.SaveAsync();
        }

        public async Task Delete(Customer customer)
        {
            UoW.CustomerRepository.Delete(customer);
            await UoW.SaveAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await UoW.CustomerRepository.GetByID(id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await UoW.CustomerRepository.Get();
        }
    }
}
