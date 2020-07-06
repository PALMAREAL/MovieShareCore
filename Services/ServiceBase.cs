using MovieShareCore.Data;
using MovieShareCore.Data.Repositories;

namespace MovieShareCore.Services
{
    public abstract class ServiceBase
    {

        public ServiceBase(IUnitOfWork unitOfWork)
        {
            UoW = unitOfWork;
        }

        protected IUnitOfWork UoW { get; }
    }
}