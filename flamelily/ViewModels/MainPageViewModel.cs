using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flamelily.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand<string> OnNavigationCommand { get; set; }

        private readonly INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Flamelily";
            _navigationService = navigationService;
            OnNavigationCommand = new  DelegateCommand<string>(NavigateAsync);
        }

        async void NavigateAsync(string page)
        {
            await _navigationService.NavigateAsync(page);
            //await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }
    }
}
