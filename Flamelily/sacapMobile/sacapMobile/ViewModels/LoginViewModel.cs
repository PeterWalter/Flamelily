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
        private string useremail;

        public string Email
        {
            get { return useremail; }
            set { 
                    if (useremail == value) return;
                    useremail = value;
                    RaisePropertyChanged("Email");
                }
        }


        public LoginViewModel()
        {
            loginCommand = new Command(loginasync);
        }

        private async void loginasync(object obj)
        {
            if (!String.IsNullOrEmpty(useremail))
                {
                await Shell.Current.GoToAsync("//home");
                }
            else
            {
                await Shell.Current.GoToAsync("//registration");
            }
           
        }
    }
}
