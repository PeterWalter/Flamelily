﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sacapMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampusView : ContentPage
    {
        public CampusView()
        {
            InitializeComponent();
          //  BindingContext = App.ViewModelLocator.campusVM;
        }
    }
}