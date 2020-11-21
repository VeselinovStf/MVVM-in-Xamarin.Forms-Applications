using BethanysPieShopStockApp.Utility;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieOverviewView : ContentPage
    {
        public PieOverviewView()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.PieOverviewViewModel;
        }
    }
}