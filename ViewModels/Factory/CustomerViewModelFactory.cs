using Microsoft.AspNetCore.Mvc.Rendering;
using MovieShareCore.Models;
using MovieShareCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public class CustomerViewModelFactory //: ViewModelFactory
    {
        public CustomerViewModel Create()
        {
            return new CustomerViewModel();
        }

        public CustomerViewModel From(Customer customer)
        {
            return new CustomerViewModel();
        }
    }
}
