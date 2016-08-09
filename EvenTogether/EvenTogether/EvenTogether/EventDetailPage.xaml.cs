using EvenTogether.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EvenTogether
{
    public partial class EventDetailPage : ContentPage
    {
        Event _receivedEvent = new Event();

        public EventDetailPage()
        {
            InitializeComponent();
        }

        public EventDetailPage(Event selectedEvent)
        {
            _receivedEvent = selectedEvent;

            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            //redireciona para a página de Login
            App.Current.MainPage = new MainPage();
            return true;
        }
    }
}
