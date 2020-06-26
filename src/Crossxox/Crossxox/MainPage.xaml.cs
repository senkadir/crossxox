using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Crossxox
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnePlayerButtonClicked(object sender, EventArgs args)
        {
            App.Current.MainPage = new GamePage();
        }
    }
}
