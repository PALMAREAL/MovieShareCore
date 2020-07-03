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
        private ICustomerService CustomerService;

        public CustomerController(ICustomerService customerService, IServiceProvider serviceProvider, IMapper mapper)
            : base(serviceProvider, mapper)
        {
            CustomerService = customerService;
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {
            var customers = await CustomerService.GetAll();

            var customerViewModel = Mapper.Map<IEnumerable<CustomerViewModel>>(customers);

            return View(customerViewModel);
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var customer = await CustomerService.GetById(id.Value);

            if (customer == null)
                return NotFound();

            var customerViewModel = Mapper.Map<CustomerViewModel>(customer);

            return View(customerViewModel);
        }


        // GET: Customer/Create
        public IActionResult Create()
        {
            var customerViewModel = GetInstance<CustomerViewModelFactory>();

            return View(customerViewModel);
        }

        // POST: Customer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Birthdate,Mail,Country,Admin")] CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                var customer = Mapper.Map<Customer>(customerViewModel);

                await CustomerService.Create(customer);

                return RedirectToAction(nameof(Index));
            }

            return View(customerViewModel);
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var customer = await CustomerService.GetById(id.Value);

            var customerViewModel = Mapper.Map<CustomerViewModel>(customer);

            if (customer == null)
                return NotFound();
            
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
                var customer = Mapper.Map<Customer>(customerViewModel);

                await CustomerService.Update(customer);

                return RedirectToAction(nameof(Index));
            }

            return View(customerViewModel);
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var customer = await CustomerService.GetById(id.Value);

            if (customer == null)
                return NotFound();

            var customerViewModel = Mapper.Map<CustomerViewModel>(customer);

            return View(customerViewModel);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await CustomerService.Delete(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
