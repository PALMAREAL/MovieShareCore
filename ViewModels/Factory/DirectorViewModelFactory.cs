using AutoMapper;
using MovieShareCore.Models;
using MovieShareCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public class DirectorViewModelFactory : ViewModelFactory<Director>
    {
        public DirectorViewModelFactory(IDirectorService directorService, IMapper mapper) 
            : base(mapper)
        {

        }

        public override ViewModel<Director> Create()
        {
            return new DirectorViewModel();
        }

        public override ViewModel<Director> From(Entity entity)
        {
            return new DirectorViewModel();
        }
    }
}
