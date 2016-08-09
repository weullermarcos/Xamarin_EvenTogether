using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EvenTogether
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        void UserType_Toggled(object sender, ToggledEventArgs e)
        {
            if (stchUserType.IsToggled)
            {
                lblUserType.Text = "Igreja";
            }
            else
            {
                lblUserType.Text = "Membro";
            }
        }

        void Genre_Toggled(object sender, ToggledEventArgs e)
        {
            if (stchGenre.IsToggled)
            {
                lblGenre.Text = "Feminino";
            }
            else
            {
                lblGenre.Text = "Masculino";
            }
        }

        protected override bool OnBackButtonPressed()
        {
            //redireciona para a página de Login
            Navigation.PopAsync();
            //App.Current.MainPage = new LoginPage();
            return true;
        }

        
        void Register_Clicked(object sender, EventArgs e)
        {
            //redireciona para a página inicial
            Navigation.PushAsync(new MainPage());
            //App.Current.MainPage = new MainPage();
        }

    }
}
