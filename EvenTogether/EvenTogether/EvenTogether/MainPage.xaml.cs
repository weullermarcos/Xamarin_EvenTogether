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
            //Evento 1
            Event myEvent1 = new Event();
            myEvent1.Name = "Evento 1";
            myEvent1.Price = "R$ 100,00";
            myEvent1.Date = DateTime.Now.AddDays(+10);
            myEvent1.Address = "Local 1";
            myEvent1.ImageSource = "evento1.png";
            _eventList.Add(myEvent1);

            //Evento 2
            Event myEvent2 = new Event();
            myEvent2.Name = "Evento 2";
            myEvent2.Price = "Gratuito";
            myEvent2.Date = DateTime.Now.AddDays(+20);
            myEvent2.Address = "Local 2";
            myEvent2.ImageSource = "evento2.png";
            _eventList.Add(myEvent2);

            //Evento 3
            Event myEvent3 = new Event();
            myEvent3.Name = "Evento 3";
            myEvent3.Price = "R$ 20,00";
            myEvent3.Date = DateTime.Now.AddDays(+20);
            myEvent3.Address = "Local 3";
            myEvent3.ImageSource = "evento3.png";
            _eventList.Add(myEvent3);

            //Evento 4
            Event myEvent4 = new Event();
            myEvent4.Name = "Evento 4";
            myEvent4.Price = "R$ 5,00";
            myEvent4.Date = DateTime.Now.AddDays(+30);
            myEvent4.Address = "Local 4";
            myEvent4.ImageSource = "evento4.png";
            _eventList.Add(myEvent4);

            myEventList.ItemsSource = _eventList;

        }

        private void TapImage_Tapped(object sender, EventArgs e)
        {

        }

        private void EventDetail_Tapped(object sender, EventArgs e)
        {
            Event item = myEventList.SelectedItem as Event;

            if (item == null)
                return;

            App.Current.MainPage = new EventDetailPage(item);
        }

        protected override bool OnBackButtonPressed()
        {
            //redireciona para a página de Login
            App.Current.MainPage = new LoginPage();
            return true;
        }

    }
}
