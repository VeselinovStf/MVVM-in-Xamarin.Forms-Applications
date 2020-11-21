using BethanysPieShopStockApp.ViewModels;

namespace BethanysPieShopStockApp.Utility
{
    public static class ViewModelLocator
    {
        public static PieDetailsViewModel PieDetailViewModel { get; set; } = new PieDetailsViewModel();

        public static PieOverviewViewModel PieOverviewViewModel { get; set; } = new PieOverviewViewModel();
    }
}
