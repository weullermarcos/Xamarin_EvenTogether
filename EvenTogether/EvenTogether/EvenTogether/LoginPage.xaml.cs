using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EvenTogether
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Login_Clicked(object sender, EventArgs e)
        {
            if (txtLogin.Text == "weuller" && txtPassword.Text ==  "123")
            {
                App.Current.MainPage = new MainPage();
            }
            else
            {
                await DisplayAlert("Erro", "Login ou Senha incorretos.", "OK");
            }
        }

        void Register_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new RegisterPage();
        }

    }
}
