using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MovieShareCore.Models;
using MovieShareCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public class MovieViewModelFactory : ViewModelFactory<Movie>
    {
        private readonly IEnumerable<SelectListItem> directors;

        private readonly IEnumerable<SelectListItem> countries;

        public MovieViewModelFactory(IMovieService movieService, IMapper mapper)
            : base(mapper)
        {
            directors = movieService.GetDirectors()
                .Result
                .Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name });

            countries = movieService.GetCountries()
                .Result
                .Select(x => new SelectListItem { Value = x.Code.ToString(), Text = x.Name });
        }

        public override ViewModel<Movie> Create()
        {
            return new MovieViewModel
            { 
                Directors = directors,
                Countries = countries
            };
        }

        public override ViewModel<Movie> From(Entity entity) 
        {
            var movieViewModel = mapper.Map<MovieViewModel>(entity);

            movieViewModel.Directors = directors;

            movieViewModel.Countries = countries;

            return movieViewModel;
        }
    }
}
