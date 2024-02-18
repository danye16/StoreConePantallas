using StoreConePantallas.Services;
using StoreConePantallas.Views;
using StoreConePantallas.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoreConePantallas
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new RegiProducto();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }
        //asdad

        protected override void OnResume()
        {
        }
    }
}
