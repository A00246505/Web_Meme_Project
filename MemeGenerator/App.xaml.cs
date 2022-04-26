using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MemeGenerator.Services;
using MemeGenerator.Views;

namespace MemeGenerator
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            DependencyService.Register<IMemeWebClient>();
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
