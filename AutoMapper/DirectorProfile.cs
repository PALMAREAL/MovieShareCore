using AutoMapper;
using MovieShareCore.Models;
using MovieShareCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.AutoMapper
{
    public class DirecctorProfile : Profile
    {
        public DirecctorProfile()
        {
            CreateMap<Director, DirectorViewModel>();
        }
    }
}
