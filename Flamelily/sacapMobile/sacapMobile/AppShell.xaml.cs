﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace sacapMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Shell.Current.GoToAsync("Login");
        }
    }
}
