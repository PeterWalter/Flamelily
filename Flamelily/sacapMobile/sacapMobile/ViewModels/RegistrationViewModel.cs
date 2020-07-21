using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace sacapMobile.ViewModels
{
    public class RegistrationViewModel : ViewModelBase
    {
        public ICommand registerCommand { get; set; }

        public RegistrationViewModel()
        {
            registerCommand = new Command(loadingasync);
        }

        private async void loadingasync(object obj)
        {
            //await Shell.Current.GoToAsync("//home");
            await Shell.Current.GoToAsync("//login");
        }
    }
}
