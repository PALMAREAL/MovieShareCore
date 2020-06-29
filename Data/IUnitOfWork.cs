﻿using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository MovieRepository { get; }

        ICustomerRepository CustomerRepository { get; }

        IDirectorRepository DirectorRepository { get; }

        void Save();

        void RollBack();
    }
}