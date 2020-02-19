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
        public Oranges(ContentPage mainPageBackground)
        {
            InitializeComponent();
            MainPageBackground = mainPageBackground;
        }

        public ContentPage MainPageBackground { get; }//data binding constructor


        async void GoGrapes(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "grapes") await Navigation.PushAsync(new Grapes(MainPageBackground));
            //goes to new page on button click
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Random random = new Random();//initialization for random number
            string[] Facts = {
                "As of 2010, Brazil grows one third of all the world's oranges.",
                "There are now over 600 varieties of oranges worldwide.",
                "Oranges originated around 4000 B.C. in Southeast Asia, from which they spread to India.",
                "Oranges are unknown in the wild. They are a hybrid of the pomelo, or “Chinese grapefruit” (which is pale green or yellow), and the tangerine.",
                "The orange tree is an evergreen, flowering tree, with an average height of 9 to 10 m(30 to 33 ft).",
                "Florida is the top orange producer in the United States.",
                "Spain has over 35 million orange trees.",
                "The word orange comes from the Arabic word Naranj.",
                
            };//hardcoded random facts
            orangeFact.Text = Facts[random.Next(8)];//changing apple label to a random fact
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MainPageBackground.BackgroundImageSource = "ORANGES.jpg";//changes mainpage background to last viewed page's background

        }
    }
}