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

            NavigationPage.SetHasNavigationBar(this, false);
        }

        public EventDetailPage(Event selectedEvent)
        {
            _receivedEvent = selectedEvent;

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            lblEventName.Text = _receivedEvent.Name;
            lblInitialDate.Text = _receivedEvent.Date.AddDays(+1).ToString();
            lblFinalDate.Text = _receivedEvent.Date.AddDays(+2).ToString();
            lblAddress.Text = _receivedEvent.Address;
            lblPrice.Text = _receivedEvent.Price;
        }

        protected override bool OnBackButtonPressed()
        {
            //redireciona para a página de Login
            Navigation.PopModalAsync();
            //App.Current.MainPage = new MainPage();
            return true;
        }
    }
}
