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

    }
}
