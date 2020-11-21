using BethanysPieShopStockApp.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieDetailsViewModel : BaseViewModel
    {
        public ICommand SavePieCommand { get; }

        public PieDetailsViewModel()
        {
            SelectedPie = new Pie();

            SavePieCommand = new Command(OnSavePie);
        }

        private void OnSavePie()
        {
            //throw new NotImplementedException();
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
