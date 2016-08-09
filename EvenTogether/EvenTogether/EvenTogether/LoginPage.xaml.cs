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
            NavigationPage.SetHasNavigationBar(this,false);
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
                Login();
            }
            else
            {
                await DisplayAlert("Erro", "Login ou Senha incorretos.", "OK");
            }
        }

        private void Login()
        {
            Navigation.PushAsync(new MainPage());
            //App.Current.MainPage = new MainPage();
        }

        void Register_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new RegisterPage());
            //App.Current.MainPage = new RegisterPage();
        }

    }
}
