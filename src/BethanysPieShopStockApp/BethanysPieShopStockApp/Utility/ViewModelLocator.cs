using BethanysPieShopStockApp.ViewModels;

namespace BethanysPieShopStockApp.Utility
{
    public static class ViewModelLocator
    {
        public static PieDetailsViewModel PieDetailViewModel { get; set; } 
            = new PieDetailsViewModel(App.PieDataService,App.NavigationService);

        public static PieOverviewViewModel PieOverviewViewModel { get; set; } 
            = new PieOverviewViewModel(App.PieDataService, App.NavigationService);
    }
}
