using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieShareCore.Models;
using MovieShareCore.Services;
using MovieShareCore.ViewModels;
using MovieShareCore.ViewModels.Factory;

namespace MovieShareCore.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly ICustomerService customerService;

        private readonly CustomerViewModelFactory customerViewModelFactory;

        public CustomerController(
            ICustomerService customerService,
            CustomerViewModelFactory customerViewModelFactory,
            IMapper mapper)
            : base(mapper)
        {
            this.customerService = customerService;
            this.customerViewModelFactory = customerViewModelFactory;
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {
            var customers = await customerService.GetAll();

            var customerViewModel = mapper.Map<IEnumerable<CustomerViewModel>>(customers);

            return View(customerViewModel);
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var customer = await customerService.GetById(id.Value);

            if (customer == null)
                return NotFound();

            var customerViewModel = mapper.Map<CustomerViewModel>(customer);

            return View(customerViewModel);
        }


        // GET: Customer/Create
        public IActionResult Create()
        {
            var customerViewModel = customerViewModelFactory.Create();

            return View(customerViewModel);
        }

        // POST: Customer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Birthdate,Mail,Country,CountrySelected,Admin")] CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                var customer = mapper.Map<Customer>(customerViewModel);

                await customerService.Create(customer);

                return RedirectToAction(nameof(Index));
            }

            return View(customerViewModel);
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var customer = await customerService.GetEntity(id.Value);

            if (customer == null)
                return NotFound();

            var customerViewModel = customerViewModelFactory.From(customer);
            
            return View(customerViewModel);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Birthdate,Mail,Country,Admin")] CustomerViewModel customerViewModel)
        {
            if (id != customerViewModel.Id)
                return NotFound();
            

            if (ModelState.IsValid)
            {
                var customer = mapper.Map<Customer>(customerViewModel);

                await customerService.Update(customer);

                return RedirectToAction(nameof(Index));
            }

            return View(customerViewModel);
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var customer = await customerService.GetById(id.Value);

            if (customer == null)
                return NotFound();

            var customerViewModel = mapper.Map<CustomerViewModel>(customer);

            return View(customerViewModel);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await customerService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
