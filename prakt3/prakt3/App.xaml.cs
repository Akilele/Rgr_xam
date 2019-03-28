using prakt3.models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prakt3
{
    public partial class App : Application
    {
        public static ApplicationContext DB { get; set; }
        public static Employee User { get; set; }

        public static NavigationPage Page;
        public App()
        {
            InitializeComponent();
            var dbName = "db.db";
            var directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var fullPath = Path.Combine(directory, dbName);
            DB = new ApplicationContext(fullPath);
            //DB.Database.Migrate();
            Page = new NavigationPage(new MainPage());
            MainPage = Page;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
