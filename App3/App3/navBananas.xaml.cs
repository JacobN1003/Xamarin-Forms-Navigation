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
    public partial class Bananas : ContentPage
    {
        public Bananas()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Random random = new Random();
            string[] Facts = {
                "The banana is actually classified as a berry",
                "The scientific name for banana is musa sapientum, which means “fruit of the wise men.",
                "Bananas float in water, as do apples and watermelons.",
                "Hawaii is the only place in the U.S.where bananas are grown commercially, although at one time they were also grown in southern California and Florida.",
                "Banana plants grow not from seeds but from bulbs.",
                "A cluster of bananas is called a hand, and a single banana is called a finger.Each banana hand has about 10 to 20 fingers.",
                "About 75 percent of the weight of a banana is water.",
                "Wrapping banana stems tightly in cling wrap will make them last three to five days longer.",
                "Banana peels are actually edible if cooked.",
                "If you peel a banana from the bottom up(holding on to the stem like a handle), you will avoid the stringy bits that cling to the fruit inside."
                };
           bananaFact.Text = Facts[random.Next(10)];
        }
    }
}