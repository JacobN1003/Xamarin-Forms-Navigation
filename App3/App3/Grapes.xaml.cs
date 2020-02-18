using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App3
{
    public partial class Grapes : ContentPage
    {
        public Grapes()
        {
            InitializeComponent();
        }

        async void GoHome(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "home") await Navigation.PopToRootAsync();
        }
    }
}
