using AutoMapper;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public abstract class ViewModelFactory<TEntity> : IViewModelFactory<TEntity>
        where TEntity : Entity
    {
        protected IMapper mapper;

        public ViewModelFactory(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public abstract ViewModel<TEntity> Create();

        public abstract ViewModel<TEntity> From(Entity entity);
    }
}
