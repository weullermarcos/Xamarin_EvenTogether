using EvenTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EvenTogether
{
    public partial class MainPage : ContentPage
    {
        private List<Event> _eventList = new List<Event>();

        public MainPage()
        {
            InitializeComponent();

            //criando um evento de tapped para a imagem
            var tapImage = new TapGestureRecognizer();
            tapImage.Tapped += TapImage_Tapped;
            imgMenu.GestureRecognizers.Add(tapImage);

            PopulateList();

        }

        private void PopulateList()
        {

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                Event myEvent1 = new Event();
                myEvent1.Name = "Evento " + i+1;
                myEvent1.Price = "R$ " + rnd.Next(10, 500) + ",00";
                myEvent1.Date = DateTime.Now.AddDays(+i);
                myEvent1.Address = "Local " + i+1;
                myEvent1.ImageSource = "evento" + rnd.Next(1, 5) + ".png";

                _eventList.Add(myEvent1);
            }



            myEventList.ItemsSource = _eventList;

        }

        private void TapImage_Tapped(object sender, EventArgs e)
        {

        }

        protected override bool OnBackButtonPressed()
        {
            //redireciona para a página de Login
            App.Current.MainPage = new LoginPage();
            return true;
        }

    }
}
