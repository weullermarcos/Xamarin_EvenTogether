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
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                await DisplayAlert("Aviso", "O Campo Login é de preenchimento obrigatório.", "OK");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                await DisplayAlert("Aviso", "O Campo Senha é de preenchimento obrigatório.", "OK");
                return;
            }

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
