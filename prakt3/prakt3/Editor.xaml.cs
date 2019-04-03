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
    public partial class Editor : ContentPage
    {
        private Ticket _ticket;
        public Editor()
        {
            InitializeComponent();  
        }

        public Editor(Ticket ticket) : this()
        {
            _ticket = ticket;
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            topic.ItemsSource = App.DB.Topics.ToList();
            if (_ticket != null) //Если редактирование, то подгружаем информацию в поля
            {
                topic.SelectedItem = _ticket.Topic;
                description.Text = _ticket.Descripton;
            }
        }

        private async void Apply_Clicked(object sender, EventArgs e)
        {
            var ticket = _ticket ?? new Ticket(); //Если _ticket != null, то он присваивается, иначе создается new Ticket();
            ticket.Topic = (Topic)topic.SelectedItem;
            ticket.Descripton = description.Text;
            if (_ticket == null) App.DB.Tickets.Add(ticket); 
            App.DB.SaveChanges();
            await App.Page.PopToRootAsync();
        }
    }
}