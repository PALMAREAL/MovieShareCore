using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public class DirectorViewModelFactory //: ViewModelFactory
    {
        public DirectorViewModel Create()
        {
            return new DirectorViewModel();
        }

        public DirectorViewModel From(Director director)
        {
            return new DirectorViewModel();
        }
    }
}
