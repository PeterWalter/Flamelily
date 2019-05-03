using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace flamelily.ViewModels
{
    public class RegistryPageViewModel : ViewModelBase
    {
        public RegistryPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "This is a Test";
        }
    }
}
