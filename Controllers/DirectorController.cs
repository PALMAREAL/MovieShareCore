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
        private IDirectorService DirectorService;

        public DirectorController(IDirectorService directorService, IServiceProvider serviceProvider, IMapper mapper)
            : base(serviceProvider, mapper)
        {
            DirectorService = directorService;
        }

        // GET: Director
        public async Task<IActionResult> Index()
        {
            var directors = await DirectorService.GetAll();

            var directorViewModel = Mapper.Map<IEnumerable<DirectorViewModel>>(directors);

            return View(directorViewModel);
        }

        // GET: Director/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var director = await DirectorService.GetById(id.Value);

            if (director == null)
                return NotFound();

            var directorViewModel = Mapper.Map<DirectorViewModel>(director);

            return View(directorViewModel);
        }

        // GET: Director/Create
        public IActionResult Create()
        {
            var directorViewModel = GetInstance<DirectorViewModelFactory>();

            return View(directorViewModel);
        }

        // POST: Director/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Birthdate,Country,Knowfor")] DirectorViewModel directorViewModel)
        {
            if (ModelState.IsValid)
            {
                var director = Mapper.Map<Director>(directorViewModel);

                await DirectorService.Create(director);

                return RedirectToAction(nameof(Index));
            }

            return View(directorViewModel);
        }

        // GET: Director/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var director = await DirectorService.GetById(id.Value);

            if (director == null)
                return NotFound();

            var directorViewModel = Mapper.Map<DirectorViewModel>(director);

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
                var director = Mapper.Map<Director>(directorViewModel);

                await DirectorService.Update(director);

                return RedirectToAction(nameof(Index));
            }

            return View(directorViewModel);
        }



        // GET: Director/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var director = await DirectorService.GetById(id.Value);

            if (director == null)
                return NotFound();

            var directorViewModel = Mapper.Map<DirectorViewModel>(director);

            return View(directorViewModel);
        }

        // POST: Director/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {          
            await DirectorService.Delete(id);
           
            return RedirectToAction(nameof(Index));
        }
    }
}
