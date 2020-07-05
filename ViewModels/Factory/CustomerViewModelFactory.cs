using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieShareCore.Models;
using MovieShareCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public class CustomerViewModelFactory : ViewModelFactory<Customer>
    {
        public CustomerViewModelFactory(ICustomerService customerService, IMapper mapper)
            : base(mapper)
        {

        }

        public override ViewModel<Customer> Create()
        {
            return new CustomerViewModel();
        }

        public override ViewModel<Customer> From(Entity entity)
        {
            return new CustomerViewModel();
        }
    }
}
