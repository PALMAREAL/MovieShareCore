using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieShareCore.Data;
using MovieShareCore.Models;
using MovieShareCore.Services;
using MovieShareCore.ViewModels;
using MovieShareCore.ViewModels.Factory;

namespace MovieShareCore.Controllers
{
    public class DirectorController : BaseController
    {
        private readonly IDirectorService directorService;

        private readonly DirectorViewModelFactory directorViewModelFactory;

        public DirectorController(
            IDirectorService directorService,
            DirectorViewModelFactory directorViewModelFactory,
            IMapper mapper)
            : base(mapper)
        {
            this.directorService = directorService;
            this.directorViewModelFactory = directorViewModelFactory;
        }

        // GET: Director
        public async Task<IActionResult> Index()
        {
            var directors = await directorService.GetAll();

            var directorViewModel = mapper.Map<IEnumerable<DirectorViewModel>>(directors);

            return View(directorViewModel);
        }

        // GET: Director/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var director = await directorService.GetById(id.Value);

            if (director == null)
                return NotFound();

            var directorViewModel = mapper.Map<DirectorViewModel>(director);

            return View(directorViewModel);
        }

        // GET: Director/Create
        public IActionResult Create()
        {
            var directorViewModel = directorViewModelFactory.Create();

            return View(directorViewModel);
        }

        // POST: Director/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Birthdate,Country,CountrySelected,Knowfor")] DirectorViewModel directorViewModel)
        {
            if (ModelState.IsValid)
            {
                var director = mapper.Map<Director>(directorViewModel);

                await directorService.Create(director);

                return RedirectToAction(nameof(Index));
            }

            return View(directorViewModel);
        }

        // GET: Director/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var director = await directorService.GetById(id.Value);

            if (director == null)
                return NotFound();

            var directorViewModel = directorViewModelFactory.From(director);

            return View(directorViewModel);
        }

        // POST: Director/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Birthdate,Country,Knowfor")] DirectorViewModel directorViewModel)
        {
            if (id != directorViewModel.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                var director = mapper.Map<Director>(directorViewModel);

                await directorService.Update(director);

                return RedirectToAction(nameof(Index));
            }

            return View(directorViewModel);
        }

        // GET: Director/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var director = await directorService.GetById(id.Value);

            if (director == null)
                return NotFound();

            var directorViewModel = mapper.Map<DirectorViewModel>(director);

            return View(directorViewModel);
        }

        // POST: Director/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await directorService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
