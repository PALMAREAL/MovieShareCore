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


        public void Create(Customer customer)
        {
            UoW.CustomerRepository.Insert(customer);
        }

        public void Update(Customer customer)
        {
            UoW.CustomerRepository.Update(customer);
        }

        public void Delete(Customer customer)
        {
            UoW.CustomerRepository.Delete(customer);
        }

        public Customer GetById(int id)
        {
            return UoW.CustomerRepository.GetByID(id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await UoW.CustomerRepository.Get();
        }
    }
}
