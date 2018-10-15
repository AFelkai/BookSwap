using Xamarin.Forms;
using System;


namespace BookSwap
{
  public partial class MainPage : ContentPage
  {
      public MainPage()
      {
         InitializeComponent();
         Init();
         buttonLogin.Clicked += async (sender, args) => await Navigation.PushAsync(new SignUp());
      }

        public void Init()
        {

            appIcon.Margin = 44;

            //BackgroundColor = Color.FromHex("4A4A4A");
            entryUsername.HeightRequest = 44;
            //entryUsername.FontSize = Constants.FontSizes.placeholderSize;
            entryUsername.BackgroundColor = Constants.Colors.entryFieldBackground;

            entryPassword.HeightRequest = 44;
            //entryPassword.FontSize = Constants.FontSizes.placeholderSize;
            entryPassword.BackgroundColor = Constants.Colors.entryFieldBackground;

            labelForgotPassword.FontSize = Constants.FontSizes.subHeaderSize;
            labelForgotPassword.Text = "Forgot Password";
            labelForgotPassword.TextColor = Color.Gray;

            labelRememberMe.FontSize = Constants.FontSizes.subHeaderSize;
            labelRememberMe.Text = "Remember me";
            labelRememberMe.TextColor = Color.Gray;

            switchRememberMe.OnColor = Constants.Colors.primaryFont;
            //switchRememberMe.IsEnabled = true;

            //buttonLogin.FontSize = Constants.FontSizes.placeholderSize;
            buttonLogin.BackgroundColor = Color.Transparent;
            buttonLogin.BorderColor = Constants.Colors.primaryFont;
            buttonLogin.TextColor = Constants.Colors.primaryFont;
            //buttonLogin.IsEnabled = true;
        }

        //async void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    await Navigation.PushAsync( new SignUp());
        //}
    }
}
