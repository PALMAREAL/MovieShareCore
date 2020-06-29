﻿using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext context;

        public UnitOfWork(IMovieRepository movieRepository, ICustomerRepository customerRepository, IDirectorRepository directorRepository)
        {
            MovieRepository = movieRepository;
            CustomerRepository = customerRepository;
            DirectorRepository = directorRepository;
        }

        public IMovieRepository MovieRepository { get; set; }

        public ICustomerRepository CustomerRepository { get; set; }

        public IDirectorRepository DirectorRepository { get; set; }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}