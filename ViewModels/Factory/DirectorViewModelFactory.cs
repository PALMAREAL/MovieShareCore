using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public class DirectorViewModelFactory : ViewModelFactory
    {
        public override ViewModel Create()
        {
            return new DirectorViewModel();
        }
    }
}
