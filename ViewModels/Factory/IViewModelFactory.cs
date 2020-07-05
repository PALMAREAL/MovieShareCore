using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public interface IViewModelFactory<TEntity>
        where TEntity : Entity
    {
        public ViewModel<TEntity> Create();

        public ViewModel<TEntity> From(Entity entity);
    }
}
