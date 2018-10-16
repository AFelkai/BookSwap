using Xamarin.Forms;

namespace BookSwap
{
   public partial class MainPage : ContentPage
   {
      public MainPage()
      {
         InitializeComponent();
         Init();

         btnLogin.Clicked += async (sender, args) => await Navigation.PushModalAsync( new Login() );
         btnSignUp.Clicked += async (sender, e) => await Navigation.PushAsync( new SignUp() );
      }

      public void Init()
      {
         NavigationPage.SetHasNavigationBar(this, false);

         btnLogin.BackgroundColor = Constants.Colors.primaryFont;
         btnLogin.TextColor = Color.White;
         btnLogin.FontAttributes = FontAttributes.Bold;
         btnLogin.HeightRequest = 60;

         btnSignUp.BackgroundColor = Color.Gray;
         btnSignUp.TextColor = Color.DarkGray;
         btnSignUp.FontAttributes = FontAttributes.Bold;
         btnSignUp.HeightRequest = 60;

         labelMessage.Text = Constants.Strings.mainPageMessage;
         labelMessage.FontAttributes = FontAttributes.Bold;
         labelMessage.TextColor = Color.WhiteSmoke;
      }
   }
}
