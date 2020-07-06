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
    public class DirectorViewModelFactory : ViewModelFactory<Director>
    {
        private readonly IEnumerable<SelectListItem> countries;

        public DirectorViewModelFactory(IDirectorService directorService, IMapper mapper) 
            : base(mapper)
        {
            countries = directorService.GetCountries()
             .Result
             .Select(x => new SelectListItem { Value = x.Code.ToString(), Text = x.Name });
        }

        public override ViewModel<Director> Create()
        {
            return new DirectorViewModel
            {
                Countries = countries
            };
        }

        public override ViewModel<Director> From(Entity entity)
        {
            var directorViewModel = mapper.Map<DirectorViewModel>(entity);

            directorViewModel.Countries = countries;

            return directorViewModel;
        }
    }
}
