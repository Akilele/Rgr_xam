using prakt3.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prakt3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            var list = App.DB.Tickets.Where(t => t.EmployeeId == App.User.Id).ToList();
            TicketsListView.ItemsSource = list;
        }

        private async void TicketsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var ticket = e.Item as Ticket;
            await App.Page.PushAsync(new ListView(ticket));
            TicketsListView.SelectedItem = null;
        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {

        }
    }
  
}