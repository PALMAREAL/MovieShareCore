using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public abstract class ViewModelFactory
    {
        public abstract ViewModel Create();

        public abstract ViewModel From(ViewModel viewModel);
    }
}
