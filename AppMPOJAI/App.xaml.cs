using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMPOJAI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new AppMPOJAI.View.VehiculoListado();
            MainPage = new AppShell();
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
