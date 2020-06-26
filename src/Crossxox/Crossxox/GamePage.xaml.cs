
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Crossxox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new MainPage();

            return true;
        }
    }
}