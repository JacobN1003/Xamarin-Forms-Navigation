using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        async void Go(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "apples") await Navigation.PushAsync(new Apples());
            if (((Button)sender).Text == "bananas") await Navigation.PushAsync(new Bananas());
            if (((Button)sender).Text == "oranges") await Navigation.PushAsync(new Oranges());
        }

        

    }
}
