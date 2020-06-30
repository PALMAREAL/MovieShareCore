using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieShareCore.ViewModels;
using MovieShareCore.ViewModels.Factory;

namespace MovieShareCore.Controllers
{
    public class BaseController : Controller
    {
        public IServiceProvider ServiceProvider;
        public IMapper Mapper;

        public BaseController(IServiceProvider serviceProvider, IMapper mapper)
        {
            ServiceProvider = serviceProvider;
            Mapper = mapper;
        }

        public ViewModel GetInstance<T>() where T : ViewModelFactory
        {
            return ((T)ServiceProvider.GetService(typeof(T))).Create();
        }
    }
}