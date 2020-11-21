using BethanysPieShopStockApp.Models;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieDetailsViewModel : BaseViewModel
    {
        public PieDetailsViewModel()
        {
            SelectedPie = new Pie();
        }

        private Pie _selectedPie;

        public Pie SelectedPie
        {
            get { return _selectedPie; }
            set 
            { 
                _selectedPie = value;
                OnPropertyChange(); 
            }
        }

    }
}
