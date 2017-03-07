using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyXamlApp.Pages;
using Xamarin.Forms;

namespace MyXamlApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MyXamlApp.Pages.MainPage();
            MainPage = new NavigationPage(new Index());
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
