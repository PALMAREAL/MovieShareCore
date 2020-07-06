using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository MovieRepository { get; }

        ICustomerRepository CustomerRepository { get; }

        IDirectorRepository DirectorRepository { get; }

        ICountryRepository CountryRepository { get; }

        Task SaveAsync();

        Task RollBackAsync();
    }
}
