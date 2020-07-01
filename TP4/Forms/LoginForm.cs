using System;
using System.Diagnostics;
using System.Text;
using TP4.Models;
using TP4.Services;
using Xamarin.Forms;

namespace TP4.Forms
{
    public class LoginForm
    {
        private readonly ITwitterService twitterService;
        private readonly Entry login;
        private readonly Entry password;
        private readonly Xamarin.Forms.Switch isRemind;
        private readonly VisibilitySwitch visibilitySwitch;
        private readonly ErrorForm error;

        private User user;

        public LoginForm(Entry login, Entry password, Xamarin.Forms.Switch isRemind, View loginForm, View tweetForm, Label errorLabel, Button button)
        {
            this.twitterService = new TwitterService();

            this.login = login;
            this.password = password;
            this.isRemind = isRemind;
            this.visibilitySwitch = new VisibilitySwitch(loginForm, tweetForm);
            this.error = new ErrorForm(errorLabel);
            button.Clicked += Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Connection Clicked");

            if (this.IsValid())
            {
                if (twitterService.Authenticate(this.user))
                {
                    this.error.Hide();
                    this.visibilitySwitch.Switch();
                }
                else
                {
                    this.error.Error = "Utilisateur non trouvé";
                    this.error.Display();
                }
            }
            else
            {
                this.error.Display();
            }
        }

        public Boolean IsValid()
        {
            Boolean result = true;

            User user = new User();
            user.Login = login.Text;
            user.Pass = password.Text;
            Boolean isRemind = this.isRemind.IsToggled;

            bool haveError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(user.Login) || user.Login.Length < 3)
            {
                haveError = true;
                stringBuilder.Append("L'identifiant ne peut pas être null et doit posséder au moins 3 caractères.");
            }

            if (String.IsNullOrEmpty(user.Pass) || user.Pass.Length < 6)
            {
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("Le mot de passe ne peut pas être null et doit posséder au moins 6 caractères.");
            }

            if (haveError)
            {
                this.error.Error = stringBuilder.ToString();
            }

            result = !haveError;
            this.user = user;

            return result;
        }
    }
}
