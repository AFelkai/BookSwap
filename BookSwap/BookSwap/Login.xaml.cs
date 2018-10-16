using Xamarin.Forms;
using System;


namespace BookSwap
{
  public partial class Login : ContentPage
  {
      public Login()
      {
         InitializeComponent();
         Init();

         btnClose.Clicked += async (sender, e) => await Navigation.PopModalAsync();

      }

        public void Init()
        {
            entryUsername.HeightRequest = 44;
            entryUsername.BackgroundColor = Constants.Colors.entryFieldBackground;
            entryPassword.HeightRequest = 44;
            entryPassword.BackgroundColor = Constants.Colors.entryFieldBackground;

            labelForgotPassword.FontSize = Constants.FontSizes.subHeaderSize;
            labelForgotPassword.Text = "Forgot Password";
            labelForgotPassword.TextColor = Color.Gray;

            labelRememberMe.FontSize = Constants.FontSizes.subHeaderSize;
            labelRememberMe.Text = "Remember me";
            labelRememberMe.TextColor = Color.Gray;

            switchRememberMe.OnColor = Constants.Colors.primaryFont;
           
            buttonLogin.BackgroundColor = Color.Transparent;
            buttonLogin.BorderColor = Constants.Colors.primaryFont;
            buttonLogin.TextColor = Constants.Colors.primaryFont;            
        }
    }
}
