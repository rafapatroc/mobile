using System;
using System.IO;
using Xamarin.Forms;
using Clothes.Data;

namespace Clothes
{
    public partial class App : Application
    {
        static ClotheDatabase database;

        public static ClotheDatabase Database
        {
            get
            {
                if (database == null)
                {
                    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ClothesDB.db3");

                    database = new ClotheDatabase(path);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ClothesPage());
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
