using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace flamelily.ViewModels
{
    public class ControlPageViewModel : BindableBase
    {
        public DelegateCommand<string> TheNavigateCommand { get; set; }
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private readonly INavigationService _navigationService;
        public ControlPageViewModel(INavigationService navigationService)
           
        {
            _title = "The fLAMELILY Menu Page";
            _navigationService = navigationService;
            TheNavigateCommand = new DelegateCommand<string>(LoadPageAsync);
        }

        private async void LoadPageAsync(string myd)
        {
            await _navigationService.NavigateAsync(myd);
        }
    }
}
