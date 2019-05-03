using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace flamelily.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public DelegateCommand<string> OnExecuteCommand { get; set; }
        private readonly INavigationService _navigationService;
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value);}
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Login page";
            _navigationService = navigationService;
            OnExecuteCommand = new DelegateCommand<string>(LoadMainpageAsync);
        }

        private async void LoadMainpageAsync(string data)
            {
                await _navigationService.NavigateAsync(data);
            }

    }
}
