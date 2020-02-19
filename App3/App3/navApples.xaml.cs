using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)] 

    public partial class Apples : ContentPage
    {
        public Apples(ContentPage mainPageBackground)
        {
            InitializeComponent();
            MainPageBackground = mainPageBackground;//passed data reference  
        }

        public ContentPage MainPageBackground { get; }//data binding constructor

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Random random = new Random();//initialization for random number
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
                "Apples are grown in all 50 states."};//hardcoded random facts
            appleFact.Text = Facts[random.Next(10)];//changing apple label to a random fact
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MainPageBackground.BackgroundImageSource = "APPLES.jpg";//changes mainpage background to last viewed page's background

        }

    }
}