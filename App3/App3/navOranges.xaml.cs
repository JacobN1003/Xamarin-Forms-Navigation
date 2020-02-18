using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Oranges : ContentPage
    {
        public Oranges()
        {
            InitializeComponent();
        }

        async void GoGrapes(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "grapes") await Navigation.PushAsync(new Grapes());
            
        }
    }
}