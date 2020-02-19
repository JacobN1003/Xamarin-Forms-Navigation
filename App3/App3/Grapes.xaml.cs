using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App3
{
    public partial class Grapes : ContentPage
    {
        public Grapes(ContentPage MainPageBackground)
        {
            InitializeComponent();
            bg = MainPageBackground;
        }

        public ContentPage bg { get; }//data binding constructor

        async void GoHome(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "home") await Navigation.PopToRootAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Random random = new Random();//initialization for random number
            string[] Facts = {
                "Grapes are botanically classed as berries",
                "Grapes appear in many colors.White, red, black, blue, green, purple and golden.",
                "There are 60 species and around 8000 varieties of grapes that can be found throughout the world today.",
                "The two main types of grapes are European and American. They come in seedless and seeded varieties.",
                "American grapes are available in September and October, while European grapes are available round the year.",
                "Grape develops on the vine that can reach length of 15 meters (50 feet). One vine usually produces 40 clusters of grape.",
                "Grapes consist of about 80% of water, which makes them a low-calorie food.",
                "Grapes are used to help cure asthma, indigestion, migraine, kidnеy disease and fatigue.",
                "Grapes contain low levels of chоlеstеrоl, sodium and fat and are rich in vitаmins K and C.",
                "Grape seeds, which are edible, are chock-full of antioxidants."
            };//hardcoded random facts
            grapeFact.Text = Facts[random.Next(10)];//changing apple label to a random fact
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            bg.BackgroundImageSource = "GRAPES.jpg";//changes mainpage background to last viewed page's background
        }

    }
}
