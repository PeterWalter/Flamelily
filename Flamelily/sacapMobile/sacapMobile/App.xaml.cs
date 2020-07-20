using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using sacapMobile.Services;
using sacapMobile.Views;
using GalaSoft.MvvmLight.Ioc;
using sacapMobile.ViewModels;

namespace sacapMobile
{
    public partial class App : Application
    {
        private static ViewModelLocator viewModelLocator;
        public static ViewModelLocator ViewModelLocator
        {
            get
            {
                return viewModelLocator ?? (viewModelLocator = new ViewModelLocator());
            }
        }
        public App()
        {
            InitializeComponent();
          //  InitContainer();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            Shell.Current.GoToAsync("login");
        }

        //private void InitContainer()
        //{
        //    SimpleIoc.Default.Reset();
        //    SimpleIoc.Default.Register<LoginViewModel>();
        //}

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
