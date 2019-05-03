using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace flamelily.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        public MenuPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Menu";
        }
    }
}
