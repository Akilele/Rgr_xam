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
    public partial class ListView : ContentPage
    {
        private Ticket _ticket;
        public ListView(Ticket ticket)
        {
            InitializeComponent();
            _ticket = ticket;
        }
        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            var _topic = App.DB.Topics.First(t => t.Id == _ticket.TopicId);
            topic.Text = _topic.Value;
            description.Text = _ticket.Descripton;
        }
        private async void EditButton_Clicked(object sender, EventArgs e)
        {
            await App.Page.PushAsync(new Editor(_ticket));
        }
    }
}