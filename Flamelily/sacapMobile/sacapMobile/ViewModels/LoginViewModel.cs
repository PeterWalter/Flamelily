using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace sacapMobile.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public ICommand loginCommand { get; set; }

        public LoginViewModel()
        {
            loginCommand = new Command(loginasync);
        }

        private async void loginasync(object obj)
        {
            await Shell.Current.GoToAsync("//registration");
        }
    }
}
