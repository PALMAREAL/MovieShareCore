﻿using MovieShareCore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieShareCore.Services
{
    public interface ICustomerService
    {

        public void Create(Customer customer);

        public void Update(Customer customer);

        public void Delete(Customer customer);

        public Customer GetById(int id);

        public Task<IEnumerable<Customer>> GetAll();

    }
}