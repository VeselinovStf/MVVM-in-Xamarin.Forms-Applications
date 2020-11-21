using BethanysPieShopStockApp.Services;
using BethanysPieShopStockApp.Views;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
    public partial class App : Application
    {
        //NOTE: Intentionally not using DI
        public static PieDataService PieDataService = 
            new PieDataService(
                new Repositories.PieRepository(
                    new Data.MockDb()));

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
