using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppComida
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login()); //habilitar navegacion 
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
