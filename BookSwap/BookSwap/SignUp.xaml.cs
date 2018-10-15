using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BookSwap
{
   public partial class SignUp : ContentPage
   {
      public SignUp()
      {
         InitializeComponent();
         init();

         //btnSubmit.Clicked += async (sender, args) => await Navigation.PushAsync( new Home() );
      }

      //void BtnSubmit_Clicked(object sender, EventArgs e)
      //{
      //   await new TabbedPage(new Home());
      //}


      public void init()
      {
         
         entryName.HeightRequest = 44;
         entryName.Completed += (sender, e) => entryEmail.Focus();
         entryName.ReturnType = ReturnType.Next;
         entryName.BackgroundColor = Constants.Colors.entryFieldBackground;

         entryEmail.HeightRequest = 44;
         entryEmail.BackgroundColor = Constants.Colors.entryFieldBackground;
         entryEmail.Completed += (sender, e) => entryPassword.Focus();
         entryEmail.ReturnType = ReturnType.Next;
         entryEmail.Keyboard = Keyboard.Email;

         entryPassword.HeightRequest = 44;
         entryPassword.BackgroundColor = Constants.Colors.entryFieldBackground;
         entryPassword.Completed += (sender, e) => entryConfirmPassword.Focus();
         entryPassword.ReturnType = ReturnType.Next;

         entryConfirmPassword.HeightRequest = 44;
         entryConfirmPassword.BackgroundColor = Constants.Colors.entryFieldBackground;
         entryConfirmPassword.Completed += EntryConfirmPassword_Completed;

         btnSubmit.BorderColor = Constants.Colors.primaryFont;
         btnSubmit.TextColor = Constants.Colors.primaryFont;
         btnSubmit.IsEnabled = true;
         btnSubmit.HeightRequest = 44;
         btnSubmit.CornerRadius = 3;
         btnSubmit.BorderWidth = .25;
         btnSubmit.BackgroundColor = Color.Transparent;

      }

      void EntryConfirmPassword_Completed(object sender, EventArgs e)
      {
         if (entryPassword.Text != entryConfirmPassword.Text)
         {
            DisplayAlert("Error", "Passwords do not match", "OK");
         } 
         else 
         {
            btnSubmit.BackgroundColor = Constants.Colors.primaryFont;
            btnSubmit.TextColor = Color.White;
         }
      }
   }
}
