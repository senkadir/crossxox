
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Crossxox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class GamePage : ContentPage
    {
        private const string DefaultUserCharacter = "X";
        private const string DefaultComputerCharacter = "O";

        private Game _game;

        public GamePage()
        {
            InitializeComponent();

            _game = new Game();

            _game.GameOver += WhenGameOver;
        }

        private async void WhenGameOver()
        {
            if (_game.Winner == string.Empty)
            {
                return;
            }

            bool answer = await DisplayAlert("Result", $"{_game.Winner} has won. Try", "Yes", "No");

            if (answer)
            {
                App.Current.MainPage = new GamePage();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new MainPage();

            return true;
        }

        public void GameMove()
        {
            int playedIndex = _game.RandomMove(DefaultComputerCharacter);

            switch (playedIndex)
            {
                case 0:
                    ZeroZero.Text = DefaultComputerCharacter;
                    break;
                case 1:
                    ZeroOne.Text = DefaultComputerCharacter;
                    break;
                case 2:
                    ZeroTwo.Text = DefaultComputerCharacter;
                    break;
                case 3:
                    OneZero.Text = DefaultComputerCharacter;
                    break;
                case 4:
                    OneOne.Text = DefaultComputerCharacter;
                    break;
                case 5:
                    OneTwo.Text = DefaultComputerCharacter;
                    break;
                case 6:
                    TwoZero.Text = DefaultComputerCharacter;
                    break;
                case 7:
                    TwoOne.Text = DefaultComputerCharacter;
                    break;
                case 8:
                    TwoTwo.Text = DefaultComputerCharacter;
                    break;
                default:
                    break;
            }
        }

        private void ZeroZero_Clicked(object sender, EventArgs e)
        {
            ZeroZero.Text = DefaultUserCharacter;

            _game.Move(DefaultUserCharacter, 0);

            GameMove();
        }

        private void ZeroOne_Clicked(object sender, EventArgs e)
        {
            ZeroOne.Text = DefaultUserCharacter;

            _game.Move(DefaultUserCharacter, 1);

            GameMove();
        }

        private void ZeroTwo_Clicked(object sender, EventArgs e)
        {
            ZeroTwo.Text = DefaultUserCharacter;

            _game.Move(DefaultUserCharacter, 2);

            GameMove();
        }

        private void OneZero_Clicked(object sender, EventArgs e)
        {
            OneZero.Text = DefaultUserCharacter;

            _game.Move(DefaultUserCharacter, 3);

            GameMove();
        }

        private void OneOne_Clicked(object sender, EventArgs e)
        {
            OneOne.Text = DefaultUserCharacter;

            _game.Move(DefaultUserCharacter, 4);

            GameMove();
        }

        private void OneTwo_Clicked(object sender, EventArgs e)
        {
            OneTwo.Text = DefaultUserCharacter;

            _game.Move(DefaultUserCharacter, 5);

            GameMove();
        }

        private void TwoZero_Clicked(object sender, EventArgs e)
        {
            TwoZero.Text = DefaultUserCharacter;

            _game.Move(DefaultUserCharacter, 6);

            GameMove();
        }

        private void TwoOne_Clicked(object sender, EventArgs e)
        {
            TwoOne.Text = DefaultUserCharacter;

            _game.Move(DefaultUserCharacter, 7);

            GameMove();
        }

        private void TwoTwo_Clicked(object sender, EventArgs e)
        {
            TwoTwo.Text = DefaultUserCharacter;

            _game.Move(DefaultUserCharacter, 8);

            GameMove();
        }
    }
}