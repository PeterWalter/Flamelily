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
           // SimpleIoc.Default.Register<CampusViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<RegistrationViewModel>();
            
        }
        //public CampusViewModel campusVM
        //{
        //    get
        //    {
        //        if (!SimpleIoc.Default.IsRegistered<CampusViewModel>())
        //        {
        //            SimpleIoc.Default.Register<CampusViewModel>();
        //        }
        //        return SimpleIoc.Default.GetInstance<CampusViewModel>();
        //    }
        //}

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
