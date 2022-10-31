using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1GermanCorea
{
    public partial class App : Application
    {
        static Controllers.DBContacto dBContac;

        public static Controllers.DBContacto dbcontac
        {
            get
            {
                if (dBContac == null)
                {
                    String DBName = "contacto.db3";
                    String PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    dBContac = new Controllers.DBContacto(PathDB);
                }

                return dBContac;
            }

        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PagePrincipal()); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
