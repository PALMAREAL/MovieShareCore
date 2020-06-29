using MovieShareCore.Data;

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