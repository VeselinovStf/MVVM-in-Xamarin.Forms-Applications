﻿using BethanysPieShopStockApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PieOverviewView();
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
