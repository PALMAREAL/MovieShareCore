using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Data
{
    public class UnitOfWork : Disposable, IUnitOfWork
    {
        private ApplicationDbContext DbContext;

        public UnitOfWork(ApplicationDbContext dbContext, IMovieRepository movieRepository, ICustomerRepository customerRepository, IDirectorRepository directorRepository)
        {
            DbContext = dbContext;
            MovieRepository = movieRepository;
            CustomerRepository = customerRepository;
            DirectorRepository = directorRepository;
        }

        public IMovieRepository MovieRepository { get; set; }

        public ICustomerRepository CustomerRepository { get; set; }

        public IDirectorRepository DirectorRepository { get; set; }


        public void RollBack()
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync()
        {
            await DbContext.SaveChangesAsync();
        }

        protected override void DisposeCore()
        {
            if (DbContext != null)
                DbContext.Dispose();
        }
    }
}
