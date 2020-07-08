using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieShareCore.Models;
using MovieShareCore.Services;
using System.Collections.Generic;
using System.Linq;

namespace MovieShareCore.ViewModels.Factory
{
    public class CustomerViewModelFactory : ViewModelFactory<Customer>
    {
        private readonly IEnumerable<SelectListItem> countries;

        public CustomerViewModelFactory(ICustomerService customerService, IMapper mapper)
            : base(mapper)
        {
            countries = customerService.GetCountries()
              .Result
              .Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name });
        }

        public override ViewModel<Customer> Create()
        {
            return new CustomerViewModel
            {
                Countries = countries
            };
        }

        public override ViewModel<Customer> From(Entity entity)
        {
            var customerViewModel = mapper.Map<CustomerViewModel>(entity);

            customerViewModel.Countries = countries;

            return customerViewModel;
        }
    }
}
