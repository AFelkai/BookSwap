using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BookSwap
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
        InitializeComponent(); Init();
    }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void Init()
        {
            appIcon.Margin = 40;
            entryUsername.FontSize = Constants.FontSizes.placeholderSize;
            entryPassword.FontSize = Constants.FontSizes.placeholderSize;

            labelForgotPassword.FontSize = Constants.FontSizes.subHeaderSize;
            labelForgotPassword.Text = "Forgot Password";
            labelForgotPassword.TextColor = Color.Gray;
               
            labelRememberMe.FontSize = Constants.FontSizes.subHeaderSize;
            labelRememberMe.Text = "Remember me";
            labelRememberMe.TextColor = Color.Gray;

            switchRememberMe.OnColor = Constants.Colors.primaryFontColor;
            switchRememberMe.HeightRequest = 8;

            buttonLogin.FontSize = Constants.FontSizes.placeholderSize;
            buttonLogin.BackgroundColor = Color.Transparent;
            buttonLogin.BorderColor = Constants.Colors.primaryFontColor;
            buttonLogin.TextColor = Constants.Colors.primaryFontColor;

            //labelCopyright.TextColor = Constants.Colors.placeholderColor;
        }

        public void switchToggled( object sender, ToggledEventArgs args)
        {
            if(args.Value){
                entryUsername.Text = entryUsername.Text;
            }
        }
    }
}
