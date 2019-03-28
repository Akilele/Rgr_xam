using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prakt3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnButtonClicked(object sender, EventArgs args)
        {
#if !DEBUG
            var empl = App.DB.Employees.Where(e => e.Login == log.Text).First();
            if (empl != null)
            {

                if (empl.Pass == pass.Text)
                {

                    App.User = empl;

                    App.Current.MainPage = new ListPage();
                }
                else
                {
                    await DisplayAlert("", "Вы ввели неверное имя пользователя или пароль", "ОК");
                }
            }
#else
            await DisplayAlert("WARNING", "Включен режим разработчика", "ОК");
            App.User = App.DB.Employees.First(e => e.Id == 1);
           
            await App.Page.PushAsync(new ListPage());
            App.Page.Navigation.RemovePage(this);

#endif
        }
    }
}
