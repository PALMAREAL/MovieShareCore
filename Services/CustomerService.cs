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
            UoW.CustomerRepository.Insert(customer).Wait();
            await UoW.SaveAsync();
        }

        public async Task Update(Customer customer)
        {
            UoW.CustomerRepository.Update(customer).Wait();
            await UoW.SaveAsync();
        }

        public async Task Delete(int id)
        {
            UoW.CustomerRepository.Delete(id).Wait(); 
            await UoW.SaveAsync();
        }

        public async Task Delete(Customer customer)
        {
            UoW.CustomerRepository.Delete(customer).Wait(); 
            await UoW.SaveAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await UoW.CustomerRepository.GetById(id);
        }

        public async Task<Customer> GetEntity(int id)
        {
            return await UoW.CustomerRepository.GetEntity(id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await UoW.CustomerRepository.Get();
        }

        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await UoW.CountryRepository.Get();
        }
    }
}