using Microsoft.AspNetCore.Mvc.Rendering;
using MovieShareCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public class CustomerViewModelFactory : ViewModelFactory
    {
        public override ViewModel Create()
        {
            return new CustomerViewModel();
        }
    }
}
