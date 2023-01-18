using System;
using Xamarin.Forms;
using System.IO;
using TipsXamarinForms.Views;
using TipsXamarinForms.Data;

namespace Tips_XamarinForms
{
    public partial class App : Application
    {
        public static DatabaseContext Context
        {
            get
            {
                if (context == null)
                {
                    InitilizeDatabase();
                }
                return context;
            }
        }
        static DatabaseContext context;
       
        public App ()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new TipsPage());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }

        private static void InitilizeDatabase()
        {
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var databasePath = Path.Combine(folderApp, "Tip.db3");
            context = new DatabaseContext(databasePath);
         }
    }
}

