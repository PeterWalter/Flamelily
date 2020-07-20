using System;
using System.Collections.Generic;
using System.Text;
//using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Xamarin.Forms.Internals;

namespace sacapMobile.ViewModels
{
    public class ViewModelLocator
    {
        //// [Preserve]
        public ViewModelLocator()
        {
            //ServiceLocator.SetLocatorProvider(() => (IServiceLocator)SimpleIoc.Default);
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<RegistrationViewModel>();
        }

        public LoginViewModel loginVM
        {
            get
            {
                if (!SimpleIoc.Default.IsRegistered<LoginViewModel>())
                {
                    SimpleIoc.Default.Register<LoginViewModel>();
                }

                return SimpleIoc.Default.GetInstance<LoginViewModel>();
            }
        }
        public RegistrationViewModel registrationVM
        {
            get
            {
                if (!SimpleIoc.Default.IsRegistered<RegistrationViewModel>())
                {
                    SimpleIoc.Default.Register<RegistrationViewModel>();
                }
                return SimpleIoc.Default.GetInstance<RegistrationViewModel>();
            }
        }

        public HomeViewModel homeVM
        {
            get
            {
                if(!SimpleIoc.Default.IsRegistered<HomeViewModel>())
                {
                    SimpleIoc.Default.Register<HomeViewModel>();
                }
                return SimpleIoc.Default.GetInstance<HomeViewModel>();
            }
        }



    }
}
