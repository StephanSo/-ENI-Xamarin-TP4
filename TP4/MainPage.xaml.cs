using System.ComponentModel;
using TP4.Forms;
using Xamarin.Forms;

namespace TP4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            new LoginForm(this.login, this.password, this.isRemind, this.loginForm, this.tweetForm, this.errorLabel, this.connection);
        }
    }
}
