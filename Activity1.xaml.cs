﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity1 : ContentPage
    {
        public Activity1()
        {
            InitializeComponent();
        }

        private async void BackPage (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}