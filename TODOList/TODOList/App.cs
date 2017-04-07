using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TODOList.Views;
using Xamarin.Forms;

namespace TODOList
{
    public class App : Application
    {
        public App()
        {
            //var navigationPage = new NavigationPage(new MainP());
            //navigationPage.BarBackgroundColor = Color.Red;
            //MainPage = navigationPage;
            MainPage = new MainP();
            
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
