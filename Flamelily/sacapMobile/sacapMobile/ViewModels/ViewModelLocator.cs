using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Ioc;

namespace sacapMobile.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<LoginViewModel>();
        }



    }
}
