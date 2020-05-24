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
            //goes to new page on button click 
            if (((Button)sender).Text == "apples") await Navigation.PushAsync(new Apples(mainPageBackground));
            if (((Button)sender).Text == "bananas") await Navigation.PushAsync(new Bananas(mainPageBackground));
            if (((Button)sender).Text == "oranges") await Navigation.PushAsync(new Oranges(mainPageBackground));
           
        }
    }
}
