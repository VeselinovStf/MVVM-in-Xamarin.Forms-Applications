using BethanysPieShopStockApp.Models;
using BethanysPieShopStockApp.Repositories;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BethanysPieShopStockApp.ViewModels
{
    public class PieOverviewViewModel : BaseViewModel
    {
        private ObservableCollection<Pie> _pies;

        public ICommand LoadPiesListCommand { get; }
        public ICommand AddNewPieCommand { get; }

        public PieOverviewViewModel()
        {
            LoadPiesListCommand = new Command(OnLoadPiesList);
            AddNewPieCommand = new Command(OnAddNewPie);          
        }

        private void OnAddNewPie()
        {
            //TODO
        }

        private void OnLoadPiesList()
        {
            Pies = new ObservableCollection<Pie>(PieRepository.GetPies());
        }

        public ObservableCollection<Pie> Pies
        {
            get { return _pies; }
            set 
            {
                _pies = value;
                OnPropertyChange();
            }
        }

    }
}
