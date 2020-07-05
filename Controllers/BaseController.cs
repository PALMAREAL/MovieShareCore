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
        public readonly IMapper mapper;

        public BaseController(IMapper mapper)
        {
            this.mapper = mapper;
        }
    }
}