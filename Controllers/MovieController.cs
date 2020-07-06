using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieShareCore.Models;
using MovieShareCore.Services;
using MovieShareCore.ViewModels;
using MovieShareCore.ViewModels.Factory;

namespace MovieShareCore.Controllers
{
    public class MovieController : BaseController
    {
        private readonly IMovieService movieService;

        private readonly MovieViewModelFactory movieViewModelFactory;

        public MovieController(
            IMovieService movieService, 
            MovieViewModelFactory movieViewModelFactory, 
            IMapper mapper)
            : base(mapper)
        {
            this.movieService = movieService;
            this.movieViewModelFactory = movieViewModelFactory;
        }

        // GET: Movie
        public async Task<IActionResult> Index()
        {
            var movies = await movieService.GetAllEntities();
            
            var movieViewModel = mapper.Map<IEnumerable<MovieViewModel>>(movies);

            return View(movieViewModel);
        }

        // GET: Movie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = await movieService.GetEntity(id.Value);

            if (movie == null)
                return NotFound();

            var movieViewModel = mapper.Map<MovieViewModel>(movie);

            return View(movieViewModel);
        }

        // GET: Movie/Create
        public IActionResult Create()
        {
            var movieViewModel = movieViewModelFactory.Create();

            return View(movieViewModel);
        }

        // POST: Movie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Director,DirectorSelected,CountrySelected,ReleaseDate,Duration,GenreId,Country,Budget")] MovieViewModel movieViewModel)
        {
            if (ModelState.IsValid)
            {
                var movie = mapper.Map<Movie>(movieViewModel);

                await movieService.Create(movie);
                
                return RedirectToAction(nameof(Index));
            }
            
            return View(movieViewModel);
        }

        // GET: Movie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = await movieService.GetEntity(id.Value);

            if (movie == null)
                return NotFound();

            var movieViewModel = movieViewModelFactory.From(movie);

            return View(movieViewModel);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Director,ReleaseDate,Duration,GenreId,Country,Budget")] MovieViewModel movieViewModel)
        {
            if (id != movieViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var movie = mapper.Map<Movie>(movieViewModel);

                await movieService.Update(movie);
                
                return RedirectToAction(nameof(Index));
            }
            
            return View(movieViewModel);
        }

        // GET: Movie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var movie = await movieService.GetEntity(id.Value);

            if (movie == null) 
                return NotFound();

            var movieViewModel = movieViewModelFactory.From(movie);

            return View(movieViewModel);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await movieService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
