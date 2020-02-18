using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Apples : ContentPage
    {
        public Apples()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Random random = new Random();
            string[] Facts = {
                "2,500 varieties of apples are grown in the United States.",
                "The crabapple is the only apple native to North America.",
                "Apples come in all shades of reds, greens, and yellows.",
                "Two pounds of apples make one 9 - inch pie.",
                "Apple blossom is the state flower of Michigan.",
                "2,500 varieties of apples are grown in the United States.",
                "7,500 varieties of apples are grown throughout the world.",
                "100 varieties of apples are grown commercially in the United States.",
                "Apples are grown commercially in 36 states.",
                "Apples are grown in all 50 states."};
            appleFact.Text = Facts[random.Next(10)];
        }


    }
}