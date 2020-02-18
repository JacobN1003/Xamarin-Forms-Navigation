using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Random;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Apples : ContentPage
    {
        public Apples()
        {
            InitializeComponent();
            appleFact.Text = "hello";
        }

        //void Handle_Appearing(object sender, System.EventArgs e)
        //{
        //    Random random = new Random();
        //    string[] facts = { "2,500 varieties of apples are grown in the United States.", "this is another fact" };
            
        //    appleFact.Text = "hello";   
            
        //}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            appleFact.Text = "hello";
        }

      
    }
}