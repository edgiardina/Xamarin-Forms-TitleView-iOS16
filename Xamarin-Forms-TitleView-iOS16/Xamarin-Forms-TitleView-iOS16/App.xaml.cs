using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Forms_TitleView_iOS16.Services;
using Xamarin_Forms_TitleView_iOS16.Views;

namespace Xamarin_Forms_TitleView_iOS16
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
